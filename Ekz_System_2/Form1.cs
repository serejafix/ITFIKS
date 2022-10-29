using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekz_System_2
{
    #region Задание 2
                                            //    Второе задание
                                            //Создать приложение, следящее за работой пользователя на компьютере.
                                            //Приложение(можно реализовать как комплекс приложений) работает в
                                            //трех режимах.
                                            //Первый режим позволяет пользователю настроить опции для слежения.
                                            //Второй режим приложения незаметно для текущего пользователя выполняет
                                            //процесс слежения (статистика и модерирование). Третий режим позволяет
                                            //посмотреть отчет о работе программы.
                                            //Во втором режиме приложение может следить за нажатиями клавиш на
                                            //клавиатуре, за списком запущенных приложений. Приложение собирает статистику и производит модерирование. Что конкретно выполнять, определяется
                                            //пользователем на этапе настройки.
                                            //Если активирована статистика, приложение записывает информацию
                                            //о всех нажатиях клавиш в файл отчета (путь настраивается пользователем
                                            //через визуальный интерфейс), о всех запускаемых приложениях(в файл отчета должна попадать информация о названии запущенного приложения и
                                            //времени запуска).
                                            //Если активировано модерирование, приложение анализирует клавиши,
                                            //нажатые пользователем.В том случае, если было набрано слово из предопределённого списка (список слов указывается при настройке приложения),
                                            //создаётся специальный файл отчета.При модерировании, если запускается
                                            //запрещенная программа (список программ указывается при настройке приложения), приложение записывает информацию о запуске в файл отчета и
                                            //закрывает запрещенную программу.
                                            // В режиме отчетности пользователь может просмотреть информацию
                                            //о клавишах и процессах (выбор пользовательского интерфейса остается за
                                            //вами).
    #endregion
    public partial class Form1 : Form
    {        
        private KeyBoardListener _listener; // хук клавиатуры

        static string Path = string.Empty; // базовый путь
        string pathKeys = @"\\KeysStatistic.txt"; // путь хука 
        string pathStartProgramReports = @"\\BanProgramsReports.txt"; // путь запрещенных программ
        string pathStartProgram = @"\\StartProgramsStatistic.txt"; // путь запущенных программ 
        string pathBannedWords = @"\\BannedWords.txt"; // путь запрещенных слов

        // 3 бул переменных для выхода с while true
        bool closeStat; 
        bool closeKeysTrack;
        bool closeBanProgramms;

        static Dictionary<string, int> wordsCount; // для подсчета запрещенных слов

        public Form1()
        {
            InitializeComponent();
            closeStat = true;
            closeBanProgramms = true;
            closeKeysTrack = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // фиксированная форма
            richTextBox_BanWords.Enabled = false;
            listBox_BannedProgram.Enabled = false;
            listBox_ListAllProgram.Enabled = false;
        }
        void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            if (closeKeysTrack == false) { return; } // для завершения считывания клавиш
            string key = e.KeyPressed.ToString(); // запись клавиши в файл ->
            if(CheckFileExist(Path + pathKeys))
            using (StreamWriter writer = new StreamWriter(Path + pathKeys, true))
            {
                writer.Write(key.ToLower());
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _listener.UnHookKeyboard();
        }
        private void button_PathReport_Click(object sender, EventArgs e)
        {
            // выбор пути через диологовое окно
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                btn_Start.Enabled = true;
                Path = fbd.SelectedPath;
                button_PathReport.Text = Path;
            }
            else
            {
                btn_Start.Enabled = false;
            }
        }

        private void checkBox_statistics_CheckedChanged(object sender, EventArgs e)
        {

            // открытие закрытие боксов
            if (checkBox_statistics.Checked)
            {
                button_PathReport.Enabled = true;
            }
            else
            {
                button_PathReport.Enabled = false;
            }
            if (checkBox_statistics.Checked && checkBox_Moderirovanie.Checked)
            {
                button_PathReport.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_PathReport.Enabled = false;
            btn_Start.Enabled = false;
        }

        private void checkBox_Moderirovanie_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Moderirovanie.Checked)
            {
                // считывание всех установленных программ на ПК ->
                button_PathReport.Enabled = true;
                richTextBox_BanWords.Enabled = true;
                listBox_BannedProgram.Enabled = true;
                listBox_ListAllProgram.Enabled = true;                
                string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
                {
                    foreach (string skName in rk.GetSubKeyNames())
                    {
                        using (RegistryKey sk = rk.OpenSubKey(skName))
                        {
                            try
                            {
                                listBox_ListAllProgram.Items.Add(sk.GetValue("DisplayName"));
                            }
                            catch (Exception)
                            { }
                        }
                    }
                }
            }
            else
            {
                button_PathReport.Enabled = false;
                richTextBox_BanWords.Enabled = false;
                listBox_BannedProgram.Enabled = false;
                listBox_ListAllProgram.Enabled = false;
                listBox_BannedProgram.Items.Clear();
                listBox_ListAllProgram.Items.Clear();
                richTextBox_BanWords.Text = "";
                btn_Start.Enabled = false;
            }
        }
        private void ListenerStart()
        {
                // начало считывания клавиш
            _listener = new KeyBoardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;
            _listener.HookKeyboard(); 
        }
        private void listBox_ListAllProgram_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_ListAllProgram.SelectedItems.Count == 0)
            {
                return;
            };
            listBox_BannedProgram.Items.Add(listBox_ListAllProgram.SelectedItems[0]);
            listBox_ListAllProgram.Items.Remove(listBox_ListAllProgram.SelectedItems[0]);
        }
        private void CheckBanWords()
        {
            // проверка всех клавиш на запрещенные слова в последовательности ->
            wordsCount = new Dictionary<string, int>();
            string[] words;
            string text;
            string[] box;
            int countWords = 0; // для подсчета слов
            if (!File.Exists(Path + pathKeys))
            {  }
            using (StreamReader sr = new StreamReader(Path + pathKeys))
            {
                text = sr.ReadToEnd();
            }
            if (CheckFileExist(Path + pathBannedWords))
            text = text.ToLower();
            box = text.Split();
            words = richTextBox_BanWords.Text.Split(new char[] { ' ', ',', '!', '.', ')', '(', '_', '?' },
                                                         StringSplitOptions.RemoveEmptyEntries);
            if (string.IsNullOrWhiteSpace(richTextBox_BanWords.Text))
            {return; }
            foreach (var s in box)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (s.Contains(words[i])) // если в файле есть запрещенное слово ->
                    {
                        for (int j = 0; j < words.Length; j++)
                        {
                            countWords = Regex.Matches(text, words[j]).Count;
                            wordsCount.Add(words[j], countWords);
                            if (wordsCount.ContainsKey(words[j])) { wordsCount[words[j]] += countWords; }
                            else { wordsCount.Add(words[j], countWords); }
                        }
                        // запись слова и его количества
                        using (StreamWriter sw = new StreamWriter(Path + pathBannedWords,true))
                        {
                            foreach (var entry in wordsCount)
                                sw.WriteLine("[{0} {1}]", entry.Key, entry.Value);
                        }
                    }
                }
            }
        }
        private bool CheckFileExist(string Paths)
        {
            // проверка чтобы не перезаписывать данные в файл
            if (File.Exists(Paths))
                File.Delete(Paths);
                return true;
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            // переменная для времени
            DateTime dateStartProcess = DateTime.Now;
            if (btn_Start.Text == "Stop")
            {
                if (checkBox_Moderirovanie.Checked)
                { CheckBanWords(); }                 
                btn_Start.Text = "Start";
                closeStat = false;
                closeKeysTrack = false;
                closeBanProgramms = false;
                checkBox_Moderirovanie.Checked = false;
                checkBox_statistics.Checked = false;
                listBox_BannedProgram.Items.Clear();
                listBox_ListAllProgram.Items.Clear();
                richTextBox_BanWords.Text = "";
                groupBox_moderirovanie.Enabled = true;
                groupBox_Stat.Enabled = true;

                DialogResult dialogResult = MessageBox.Show("Посмотреть отчет?", "Отчет!", MessageBoxButtons.YesNo); // выбор печтать отчет или нет ->
                if (dialogResult == DialogResult.Yes)
                {
                    // создание формы для отображения статистики
                    AllReports allReportsForm = new AllReports(Path, pathKeys, pathStartProgramReports, pathBannedWords, pathStartProgram);
                    allReportsForm.Show();
                }
                else
                {
                    this.Close(); // если нет, просто выходим
                }
                return;
            }
            Action bannedProcess = () =>
            {
                if (CheckFileExist(Path + pathStartProgramReports))
                    // при запуске бесконечный цикл смотрит за процессами и закрывает запрещенный ->
                    while (true)
                    {
                    if (closeBanProgramms == false) { return; }
                    var process = Process.GetProcesses();
                    foreach (var p in process)
                    {
                        try
                        {
                            Action act = () => {
                                foreach (var item in listBox_BannedProgram.Items)
                                {
                                    string i = item.ToString().ToLower();
                                    if (p.ProcessName.ToLower().Contains(i))
                                    {
                                        p.Kill();
                                        using (StreamWriter sw = new StreamWriter(Path + pathStartProgramReports, true))
                                        {
                                            sw.WriteLine($"Имя->{p.ProcessName}->Время-Старта->{p.StartTime}");
                                        }
                                    }
                                }
                            };
                            if (this.InvokeRequired)
                                this.Invoke(act);
                            else act();
                        }
                        catch (Exception)
                        {
                            continue;
                        }                     
                    }
                }
            };
            Action startProcess = () =>
            {
                    // считывание всех ново запущенных процессов ->
                    if (CheckFileExist(Path + pathStartProgram))
                    while (true)
                    {
                    if (closeStat == false) { return; }
                    var process = Process.GetProcesses();
                    foreach (var p in process)
                    {
                        try
                        {
                            if (p.StartTime > dateStartProcess)
                            {
                                using (StreamWriter sw = new StreamWriter(Path + pathStartProgram, true))
                                {
                                    sw.WriteLine($"Имя->{p.ProcessName}->Время-Старта->{p.StartTime}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }

                    }
                    }
            };
            if (checkBox_statistics.Checked && checkBox_Moderirovanie.Checked)
            {
                // полный запуск
                if (string.IsNullOrWhiteSpace(richTextBox_BanWords.Text))
                { MessageBox.Show("Enter Words"); return; }
                Task.Run(bannedProcess);
                Task.Run(startProcess);
                ListenerStart();
                btn_Start.Text = "Stop";
                groupBox_moderirovanie.Enabled = false;
                groupBox_Stat.Enabled = false;
                this.WindowState = FormWindowState.Minimized;
                return;
            }

            if (checkBox_statistics.Checked)
            {
                // запуск только статистики
                ListenerStart();
                Task.Run(startProcess);
                groupBox_moderirovanie.Enabled = false;
                groupBox_Stat.Enabled = false;
            }
            if (checkBox_Moderirovanie.Checked)
            {
                // запуск только модерирования
                if (string.IsNullOrWhiteSpace(richTextBox_BanWords.Text))
                { MessageBox.Show("Enter Words"); return; }
                Task.Run(bannedProcess);
                ListenerStart();
                groupBox_moderirovanie.Enabled = false;
                groupBox_Stat.Enabled = false;
            }
            this.WindowState = FormWindowState.Minimized;
            btn_Start.Text = "Stop";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // проверки чтобы запуск не произошел без нужного выбора ->
            if ((!checkBox_Moderirovanie.Checked) && checkBox_statistics.Checked)
            {
                btn_Start.Enabled = true;
            }
            if ((!checkBox_statistics.Checked) && checkBox_Moderirovanie.Checked)
            {
                btn_Start.Enabled = true;
            }
            if (!(checkBox_Moderirovanie.Checked && checkBox_statistics.Checked))
            {
                btn_Start.Enabled = false;
            }
            if (checkBox_statistics.Checked)
            {
                btn_Start.Enabled = true;
            }
            if (checkBox_Moderirovanie.Checked)
            {
                btn_Start.Enabled = true;
            }
        }
    }
}

