using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;

namespace tessssss
{
    class Program
    {
        //string pathTo = @"G:\Temp";
        //static DirectoryInfo[] dirs;
        static void Main(string[] args)
        {

            char[] a = { 'J', 'a', 'v', 'a', '!' };
            con
        //string input = "a fiks miks a";
        ////string pattern = @"\bfiks\b";
        ////string replacement = "miks";
        ////string result = Regex.Replace(input, pattern, replacement);

        //string[] words = { "fiks", "miks" };
        //int[] counts;
        //for (int g = 0; g < words.Length; g++)
        //{
        //    int count = Regex.Matches(input, words[g]).Count;               
        //}

        //Console.WriteLine(result);

        //var a = new Regex("[0-9]");
        //Console.WriteLine(a.Matches("1234").Count);
        //Console.ReadKey();

        //    string[] Drives = Environment.GetLogicalDrives();//Получаем диски на комьютере
        //    List<DirectoryInfo> directories = new List<DirectoryInfo>();//Создаем список для путей всех папок

        //    //обход дисков - запись всех путей всех папок на дисках в список
        //    for (int i = 0; i < Drives.Length; i++)
        //    {
        //        DirectoryInfo dinfo = new DirectoryInfo(Drives[i]);//Получаем дерикторию в которой надо обойти папки, в данном случае диск
        //        try
        //        {
        //            dirs = dinfo.GetDirectories();//Получаем поддериктории(папки в папке) из текущей дериктории(в данном случае диск)
        //        }
        //        catch (IOException e)
        //        {
        //            Console.WriteLine($"Диск: {dinfo} пуст");
        //            continue;
        //        }
        //        foreach (DirectoryInfo current in dirs)
        //        {
        //            directories.Add(current);//Добавляем в список дериктории из массива (т.к. может быть больше одного диска на компьютере)
        //        }
        //    }

        //    //обход всех папок и получение файлов в них
        //    List<FileInfo> filesList = new List<FileInfo>();

        //    for (int i = 0; i < directories.Count; i++)
        //    {
        //        try//оборачиваем try catch из за возможности встретить дериктории к которым запрещен доступ
        //        {
        //            DirectoryInfo dinfo = new DirectoryInfo(directories[i].FullName);//получаем полный путь каждой папки находящихся на дисках
        //            FileInfo[] files = dinfo.GetFiles();//получаем файлы из текущей папки
        //            foreach (FileInfo current in files)
        //            {
        //               string a =  GetResourceFileContentAsString(current.ToString());
        //                filesList.Add(current);//Добавляем в общий список файлов
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //        }
        //    }
        //}
        //public static void test()
        //{
        //    using (Stream stream = GetResourceStream("MyApplication.Document1.rtf"))
        //    {
        //        stream.Seek(0, SeekOrigin.Begin);
        //        wordProcessor.LoadDocument(stream);
        //        stream.Close();
        //    }
        //    Stream GetResourceStream(string resourceName)
        //    {
        //        return Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
        //    }
        //}
        //public static string GetResourceFileContentAsString(string fileName)
        //{
        //    var assembly = Assembly.GetExecutingAssembly();

        //    string resource = null;
        //    using (Stream stream = assembly.GetManifestResourceStream(fileName))
        //    {
        //        using (StreamReader reader = new StreamReader(stream))
        //        {
        //            resource = reader.ReadToEnd();
        //        }
        //    }
        //    return resource;
        //}
        //public static void SearchAllFiles(string path, string pathTo)
        //{
        //    //string path = @"D:\files\"; // откуда
        //    // куда

        //    string[] extensions = { "*.jpg", "*.txt", "*.asp" };

        //    foreach (string ext in extensions)
        //    {
        //        foreach (string file in Directory.GetFiles(path, ext, SearchOption.AllDirectories))
        //        {
        //            File.Copy(path + Path.GetFileName(file), pathTo + Path.GetFileName(file));
        //        }
        //    }
        //}

    }
    }
    
}
