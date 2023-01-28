using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using AngleSharp;
using AngleSharp.Dom;
using TZ_Parsing.DB;

namespace TZ_Parsing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    //Задача

    //Есть 2 сайта www.ilcats.ru, catcar.info
    //У ilcats более надежная система антипарсинга, парсинг этого сайта будет засчитываться выше баллом.У catcar менее надежная система антипарсинга,
    //построена на количестве запросов в один период времени. Какой сайт парсить выберите сами, главное чтобы вы поняли алгоритм что описан ниже на примере сайта ilcats.ru.
    //В catcar тоже есть те же самые данные, но по другому расположены и со своими ссылками.



    //https://www.ilcats.ru/toyota/?function=getModels&market=EU
    // линк для парса



    public class Parser
    {
        
    }

    public partial class MainWindow : Window
    {
        private ParserDbContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ParserDbContext(); // создаем сущность базы данных
            //NoDuplicateData(); 
        }


        // заполнял таблицы, эти таблицы для избежания дублирования данных, есть всего 2 системы трансмиссии и 2 позиции водителя, поэтому чтобы каждый раз не писать поступил таким образом.
        private void NoDuplicateData()
        { 
             var transmission1 = new AtmMtm()
             {
                 Transmission = "Automatic Transmission"
             };
             var transmission2 = new AtmMtm()
             {
                 Transmission = "Manual Transmission"
             };
             var driverposition1 = new DriverPosition()
             {
                 Position = "Left-Hand"
             };
             var driverposition2 = new DriverPosition()
             {
                 Position = "Right-Hand"
             };
             db.DriverPositions.Add(driverposition1);
             db.DriverPositions.Add(driverposition2);
             db.AtmMtms.Add(transmission1);
             db.AtmMtms.Add(transmission2);
             db.SaveChanges();
        }

        private async void getParsing_Click(object sender, RoutedEventArgs e)
        {
            var url = txbLink.Text; // ссылка для парсинга

            var config = Configuration.Default.WithDefaultLoader(); // стандартные конфигурации AngleSharp ->

            var context = BrowsingContext.New(config);

            if (!string.IsNullOrEmpty(url)) // если поле не пустой начинаем ->
            {             
                var doc = await context.OpenAsync(url); // по первой ссылке отправляем запрос

                var parsList = doc.QuerySelectorAll(".List"); // выбираю откуда парсить

                foreach (var par in parsList.Take(20).Skip(1)) //парсил несколько линий, чтобы не усложнять, можно поставить, сколько нужно
                {
                    string NameModel = string.Empty;
                    string Equip = string.Empty;
                    string EquipmentUrl = null; // строка для нового парса, там где лежат конфигурации, если перейти по ID
                    int CodeModelId = 0;
                    string DateRange = string.Empty;
                    try // обошел таким способом исключения,которое выскакивало, когда в неких марках машины были по 2 ID, для упрощения задания
                    {
                        NameModel = par.QuerySelector(".Header").TextContent;
                        CodeModelId = Convert.ToInt32(par.QuerySelector(".id").TextContent); // беру код модели для создания ссылки
                        Equip = par.QuerySelector(".modelCode").TextContent;
                        DateRange = par.QuerySelector(".dateRange").TextContent;// беру дату модели для создания ссылки
                    }
                    catch (Exception) { continue; }

                    string[] Dates = DateRange.Split(new char[] { '.', '-' }, StringSplitOptions.RemoveEmptyEntries); //распарсиваю так как в ссылки дата лежит в другом порядке

                    // создание ссылок двух типов, так как есть даты полные и не полные соответственно
                    if (Dates.Length == 3)
                    {
                        EquipmentUrl = "https://www.ilcats.ru/toyota/?function=getComplectations&market=EU&model=" + CodeModelId.ToString() + "&startDate=" + Dates[1] + Dates[0];
                    }
                    if(Dates.Length == 4)
                    {
                        EquipmentUrl = "https://www.ilcats.ru/toyota/?function=getComplectations&market=EU&model=" + CodeModelId.ToString() + "&startDate=" + Dates[1] + Dates[0] + "&endDate=" + Dates[3] + Dates[2];
                    }

                    var configurationUrl = await context.OpenAsync(EquipmentUrl); // по новой ссылке отправляем запрос

                    var configurationNameParse = configurationUrl.QuerySelectorAll("td"); // выбираю откуда парсить

                    List<string> listConfiguration = new List<string>(); // два листа для хранения имя таблицы и её значения ->

                    List<string> listConfiguration1 = new List<string>();

                    var configurationParse = configurationUrl.QuerySelectorAll("th"); // парсим имена таблицы и записываем в лист ->

                    foreach (var item in configurationParse.Take((configurationParse.Length) / 2 + 1).Skip(2))
                    {
                        listConfiguration.Add(item.TextContent);
                    }

                    foreach (var value in configurationNameParse.Take((configurationParse.Length) / 2 + 1).Skip(2)) // парсим значения таблицы и записываем в лист ->
                    {
                        if (value.QuerySelector("div") != null)
                        {
                            listConfiguration1.Add(value.QuerySelector("div").TextContent);
                        }
                        else
                        {
                            listConfiguration1.Add(null);
                        }
                    }
                    
                    // из листов делаем массивы, затем из массивов ключ значение диктионари
                    var keys = listConfiguration.ToArray();
                    var values = listConfiguration1.ToArray();

                    Dictionary<string, string> ConfigurationParse = keys
                    .Distinct()
                    .Select((key, i) => new {
                        key,
                        value = values[i % values.Length]
                    })
                    .ToDictionary(item => item.key, item => item.value);

                    Equipment eq; // создаем экземпяр сущности и заполняем свойства для передачи в БД ->

                    eq = new Equipment();

                    // переберираю ключ значения и добавляю по нужным свойствам , можно было сделать enum но мало времени

                    #region Перебор таблицы 
                    try
                    {
                        foreach (var item in ConfigurationParse)
                        {
                            
                            switch (item.Key)
                            {
                                case "ENGINE 1":
                                    // выбираю откуда парсить
                                    eq.Engine1 = item.Value;
                                    break;

                                case "BODY":
                                    eq.Body = item.Value;
                                    break;

                                case "GRADE":
                                    eq.Grade = item.Value;
                                    break;

                                case "ATM,MTM":
                                    {
                                        if (item.Value == "AUTOMATIC TRANSMISSION")
                                        {
                                            eq.AtmMtmId = 1;
                                        }
                                        else
                                        {
                                            eq.AtmMtmId = 2;
                                        }
                                    }
                                    break;

                                case "GEAR SHIFT TYPE":
                                    eq.GearShiftType = item.Value;
                                    break;

                                case "PRODUCT":
                                    eq.Product = item.Value;
                                    break;

                                case "DRIVER'S POSITION":
                                    {
                                        if (item.Value == "LHD")
                                        {
                                            eq.DriverPositionId = 1;
                                        }
                                        else
                                        {
                                            eq.DriverPositionId = 2;
                                        }
                                    }
                                    break;

                                case "NO.OF DOORS":
                                    eq.NoOfDoors = item.Value;
                                    break;

                                case "FUEL INDUCTION":
                                    eq.FuelInduction = item.Value;
                                    break;
                                case "CAB":
                                    eq.Cab = item.Value;
                                    break;

                                case "TRANSMISSION MODEL":
                                    eq.TransmissionModel = item.Value;
                                    break;

                                case "LOADING CAPACITY":
                                    eq.LoadingCapacity = item.Value;
                                    break;
                                case "REAR TIRE":
                                    eq.RearTire = item.Value;
                                    break;

                                case "DESTINATION":
                                    eq.Destination = item.Value;
                                    break;

                                case "BUILDING CONDITION":
                                    eq.BuildingCondition = item.Value;
                                    break;
                                case "DESTINATION 1":
                                    eq.Destination1 = item.Value;
                                    break;

                                case "DESTINATION 2":
                                    eq.Destination2 = item.Value;
                                    break;

                                case "SEATING CAPACITY":
                                    eq.SeatingCopacity = item.Value;
                                    break;
                                case "SIDE WINDOW":
                                    eq.SideWindow = item.Value;
                                    break;
                                case "DECK":
                                    eq.Deck = item.Value;
                                    break;
                                case "DECK(MATERIAL)":
                                    eq.DeckMaterial = item.Value;
                                    break;
                                case "DECK,CAB":
                                    // выбираю откуда парсить
                                    eq.DeckCab = item.Value;
                                    break;
                                case "MODEL MARK":
                                    // выбираю откуда парсить
                                    eq.ModelMark = item.Value;
                                    break;
                            }
                        }
                    }
                    catch (Exception) { }
                    #endregion
                    eq.Id = CodeModelId; // ключ это ID каждой марки
                    db.Equipments.Add(eq); // добавляем экземляр с конфигурациями
                    db.SaveChanges();
                    eq = null;
                   

                    Main m = new Main();
                    if (!(string.IsNullOrEmpty(Equip) || string.IsNullOrEmpty(NameModel)))
                    {
                        m.NameModel = NameModel;
                        m.CodeModelId = CodeModelId;
                        m.DateRange = DateRange;
                        m.Equip = Equip;
                        if (m != null)
                        {
                            db.Mains.Add(m);
                            db.SaveChanges(); // сохраняю изменения и впринцепи всё,можно сделать более качественно. PS мало света )
                            m = null;
                        }
                    }
                }               
                //dgv.ItemsSource = db.Mains.ToList();
            }
        }
    }
 }
