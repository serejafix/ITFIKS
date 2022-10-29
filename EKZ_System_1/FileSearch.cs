using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKZ_System_1
{
    public class FileSearch
    {
        #region Task1
        //Реализовать приложение, позволяющее искать некоторый набор запрещенных слов в файлах.
        #endregion

        public delegate void  UpdateLabelDR(DialogResult result); // событие для передачи результата окончания программы->
        public event UpdateLabelDR EventDR;

        public delegate void  UpdateLabelPath(string d);// событие для передачи пути папок в которых найден нужный файл ->
        public event UpdateLabelPath EventPath;

        private DialogResult result; //результат окончания программы

        private string[] Drives; // список дисков

        public string[] _words; // для сплит, ключевых слов

        private string pathTemp = @"C:\EkzTempFiles\"; // путь к папке для хранения копий
        private const string pathReport = @"C:\EkzTempFiles\отчет.txt"; // путь отчета
        private const string pathReports = @"C:\EkzTempFiles\ошибки.txt"; // путь отчета ошибок

        private DirectoryInfo[] dirs;// для директорий
        private List<DirectoryInfo> directories;// для директорий
        private DirectoryInfo dinfo; // для директорий

        private Dictionary<string, int> FileEqualCount; // если название файлов одинаковые, делаем как на виндовс меня и приставляем count
        private Dictionary<string, int> WordsFindCount; // количество найденных слов в каждом файле
        private Dictionary<string, int> WordsFindCountAll; // всего найденных слов

        private List<string> listExeptions;// лист хранящий в себе ошибки
        public FileSearch(string [] words)
        {
            _words = words; // разбиваем слов, которые пришли при создание экземпляра
            directories = new List<DirectoryInfo>(); //Создаем список для путей всех папок          
            WordsFindCountAll = new Dictionary<string, int>(); // подсчет количества найденных слов
            Drives = Environment.GetLogicalDrives(); //Получаем список дисков
            listExeptions = new List<string>(); // лист хранящий в себе ошибки
            FileEqualCount = new Dictionary<string, int>(); // если файлы будут с одинаковым названием но в разных папках, тогда меняем им название
            WordsFindCount = new Dictionary<string, int>(); // подсчет количества найденных файлов
        }

        // читаем файл
        private void ReadFile(string path) 
        {
            string text;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    text = reader.ReadToEnd();
                    CheckWords(text, _words, path); // проверяем
                }               
            }
            catch (Exception ex )
            {
                listExeptions.Add(ex.Message);                      
            }            
        }

        //проверка текста в файле на запрещенное слово
        private void CheckWords(string text, string[] words, string path)
        {
            int countWords = 0; // для подсчета слов
            string[] box = text.Split(); // сплит для проверки на запрещенное слово
            string pathfromCopy = pathTemp + Path.GetFileName(path); // путь для скопированных файлов
            string pathfromCopyStars = pathTemp + "Copy_" + Path.GetFileName(path); // путь для файла с заменами на *
            string pathfromCopyEqual = pathTemp + Path.GetFileName(path); // путь для одиноковых файлов            
            FileInfo fi = new FileInfo(path);
            foreach (string s in box)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (s.Contains(words[i])) // если в файле есть запрещенное слово ->
                    {
                        for (int g = 0; g < words.Length; g++)
                        {
                            countWords = Regex.Matches(text, words[g]).Count;
                            WordsFindCount.Add(words[g], countWords);
                            if (WordsFindCountAll.ContainsKey(words[g])) { WordsFindCountAll[words[g]] += countWords; }
                            else { WordsFindCountAll.Add(words[g], countWords); }
                        }
                        using (StreamWriter file = new StreamWriter(pathReport, true))
                        {
                            file.WriteLine($"Путь к файлу>{fi.FullName}>Размер>{fi.Length}");
                            foreach (var entry in WordsFindCount)
                                file.WriteLine("[{0} {1}]", entry.Key, entry.Value);
                        }
                        WordsFindCount.Clear();
                        if (FileEqualCount.ContainsKey(Path.GetFileName(pathfromCopy))) // проверямем если ли похожий файл в дикт
                        {
                            FileEqualCount[Path.GetFileName(pathfromCopy)]++; // если есть, увеличиваем значение для построение смены названия файла
                        }
                        else
                        {
                            FileEqualCount.Add(Path.GetFileName(pathfromCopy), 0); // если нет, просто добавляем
                        }
                        if (File.Exists(pathfromCopy)) // проверка есть ли такой файл
                        {
                            string equalsPath = pathTemp + FileEqualCount[Path.GetFileName(pathfromCopy)].ToString() + Path.GetFileName(path);
                            string equalsPathCopy = pathTemp + FileEqualCount[Path.GetFileName(pathfromCopy)].ToString() + "Copy" + Path.GetFileName(path);
                            File.Copy(path, equalsPath, true); // файл копируется в заданную папку
                            for (int j = 0; j < words.Length; j++)
                            {
                                text = text.Replace(words[j], "*******");  // заменяем каждое запрещенное слово на *                          
                            }
                            using (StreamWriter writer = new StreamWriter(equalsPathCopy, false)) // запись в новый файл в новую папку
                            {
                                writer.Write(text);
                            }
                            return;
                        }
                        else
                        {
                            File.Copy(path, pathfromCopy, true); // файл копируется в заданную папку
                            for (int j = 0; j < words.Length; j++)
                            {
                                text = text.Replace(words[j], "*******");  // заменяем каждое запрещенное слово на *                          
                            }
                            using (StreamWriter writer = new StreamWriter(pathfromCopyStars, false)) // запись в новый файл в новую папку
                            {
                                writer.Write(text);
                            }
                            return;
                        }
                    }
                }
            }
        }
        // запуск
        public async void Run()
        {
            await Task.Run(() => GetFiles()); // асинхронный запуск метода (получение дисков,папок,файлов на всем компьютере)
            var sortedDict = (from entry in WordsFindCountAll
                              orderby entry.Value descending
                              select entry
                  ).Take(10)
                  .ToDictionary(pair => pair.Key, pair => pair.Value);
            await Task.Run(() =>
            {
                using (StreamWriter file = new StreamWriter(pathReport, true))
                {
                    file.WriteLine("---Топ 10---");
                        foreach (var item in sortedDict)
                        {                              
                            file.WriteLine(item);
                        }   
                }
                using (StreamWriter writer = new StreamWriter(pathReports, true)) // запись в новый файл в новую папку
                {
                    foreach (var item in listExeptions)
                    {
                        writer.WriteLine(item + "\n");
                    }                 
                }
            });
            result = MessageBox.Show("Program completed");
            if (result == DialogResult.OK)
            {
                EventDR(result);
            }
        }
        // получение файлов
        private  void GetFiles()
        {         
            DirectoryInfo dirInfo = new DirectoryInfo(pathTemp); // очистка файлов в папке при запуске ->

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                try // для обхода системных файлов 
                {
                    file.Delete();
                }
                catch (Exception ex)
                {
                    listExeptions.Add(ex.Message);
                    continue;
                }              
            }
            //обход дисков - запись всех путей всех папок на дисках в список
            for (int i = 0; i < Drives.Length; i++)
            {
                dinfo = new DirectoryInfo(Drives[i]);//Получаем дерикторию в которой надо обойти папки, в данном случае диск                                
                Thread.Sleep(100); // для того чтобы увидеть это изменение на форме(на моей компьюторе слишком быстро, не знаю как на других:))
                try
                {
                    dirs = dinfo.GetDirectories();//Получаем поддериктории(папки в папке) из текущей дериктории(в данном случае диск)
                }
                catch (IOException ex)
                {
                    listExeptions.Add(ex.Message);
                    continue;
                }
                foreach (DirectoryInfo current in dirs)
                {
                    directories.Add(current);//Добавляем в список дериктории из массива (т.к. может быть больше одного диска на компьютере)
                }
            }

            for (int i = 0; i < directories.Count; i++)
            {
                try//оборачиваем try catch из за возможности встретить дериктории к которым запрещен доступ
                {
                    DirectoryInfo dinfo = new DirectoryInfo(directories[i].FullName);//получаем полный путь каждой папки находящихся на дисках
                    if (dinfo.Name == @"EkzTempFiles")
                    {
                        continue;
                    }
                    FileInfo[] files = dinfo.GetFiles();//получаем файлы из текущей папки
                    foreach (FileInfo current in files)
                    {
                        if (current.Extension == ".txt")
                        {
                            EventPath(current.DirectoryName);
                            Thread.Sleep(100); // для того чтобы увидеть это изменение на форме(на моей компьюторе слишком быстро, не знаю как на других:))
                            ReadFile(current.FullName);
                        }    
                    }
                }
                catch (Exception ex)
                {
                    listExeptions.Add(ex.Message);
                }
            }
        }
    }
}
