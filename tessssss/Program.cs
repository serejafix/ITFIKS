﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tessssss
{
    public class newclass
    {
        private string _MyProperty = "";
        public string MyProperty
        {
            get { return _MyProperty; }
            set { _MyProperty = value; }
        }
        public virtual void Ok() { Console.WriteLine(MyProperty); }

    }
    class doch:newclass
    {
        
    }
    class Program
    {

        static void Main(string[] args)
        {
            newclass newclass = new newclass {MyProperty = "super" };
            newclass.Ok();

            newclass doch = new doch {MyProperty =  "doch" };
            doch.Ok();

            //var files = new List<string>();
            ////@Stan R. suggested an improvement to handle floppy drives...
            ////foreach (DriveInfo d in DriveInfo.GetDrives())
            //foreach (DriveInfo d in DriveInfo.GetDrives().Where(x => x.IsReady == true))
            //{
            //    files.AddRange(Directory.GetFiles(d.RootDirectory.FullName, "Файл.txt", SearchOption.AllDirectories));
            //}
            //Console.WriteLine(files);

            //string path = @"I:\";
            //Queue<string> DirList = new Queue<string>();
            //DirList.Enqueue(path);
            //while (DirList.Count != 0)
            //{
            //    path = DirList.Dequeue();

            //    DirectoryInfo DI = new DirectoryInfo(path);

            //    foreach (DirectoryInfo dir in DI.GetDirectories())
            //    {
            //        try
            //        {
            //            dir.GetDirectories();
            //            DirList.Enqueue(dir.FullName);
            //        }
            //        catch { }
            //    }
            //}
            

           
            

            //string catalog = @"I:\";

            //string fileName = "Файл.txt";
          
            //foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName,
            //    SearchOption.AllDirectories))
            //{
            //    FileInfo FI;
            //    try
            //    {
                    
            //        FI = new FileInfo(findedFile);
                    
            //        Console.WriteLine(FI.Name + " " + FI.FullName + " " + FI.Length + "_байт" +
            //            " Создан: " + FI.CreationTime);
            //    }

            //    catch 
            //    {
            //        continue;
            //    }
            //}
        }
    }
}
