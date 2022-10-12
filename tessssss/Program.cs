using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tessssss
{
    class Program
    {
        static DirectoryInfo[] dirs;
        static void Main(string[] args)
        {
            string[] Drives = Environment.GetLogicalDrives();//Получаем диски на комьютере
            List<DirectoryInfo> directories = new List<DirectoryInfo>();//Создаем список для путей всех папок

            //обход дисков - запись всех путей всех папок на дисках в список
            for (int i = 0; i < Drives.Length; i++)
            {
                DirectoryInfo dinfo = new DirectoryInfo(Drives[i]);//Получаем дерикторию в которой надо обойти папки, в данном случае диск
                try
                {
                    dirs = dinfo.GetDirectories();//Получаем поддериктории(папки в папке) из текущей дериктории(в данном случае диск)
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Диск: {dinfo} пуст");
                    continue;
                }
                foreach (DirectoryInfo current in dirs)
                {
                    directories.Add(current);//Добавляем в список дериктории из массива (т.к. может быть больше одного диска на компьютере)
                }
            }

            //обход всех папок и получение файлов в них
            List<FileInfo> filesList = new List<FileInfo>();

            for (int i = 0; i < directories.Count; i++)
            {
                try//оборачиваем try catch из за возможности встретить дериктории к которым запрещен доступ
                {
                    DirectoryInfo dinfo = new DirectoryInfo(directories[i].FullName);//получаем полный путь каждой папки находящихся на дисках
                    FileInfo[] files = dinfo.GetFiles();//получаем файлы из текущей папки
                    foreach (FileInfo current in files)
                    {
                        filesList.Add(current);//Добавляем в общий список файлов
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        public static void SearchAllFiles()
        {
            string path = @"D:\files\"; // откуда
            string pathTo = @"D:\files\copied\"; // куда

            string[] extensions = { "*.jpg", "*.txt", "*.asp" };

            foreach (string ext in extensions)
            {
                foreach (string file in Directory.GetFiles(path, ext, SearchOption.AllDirectories))
                {
                    File.Copy(path + Path.GetFileName(file), pathTo + Path.GetFileName(file));
                }
            }
        }
    }
}
