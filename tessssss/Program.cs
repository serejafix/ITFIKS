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
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;

namespace tessssss
{
    class Program
    {
        static async Task Main(string[] args)
        {



            //var url = txbLink.Text; // ссылка для парсинга

            var config = Configuration.Default.WithDefaultLoader(); // стандартные конфигурации AngleSharp ->

            var context = BrowsingContext.New(config);

            //if (!string.IsNullOrEmpty(url)) // если поле не пустой начинаем ->
            //{
                var doc = await context.OpenAsync("https://www.ilcats.ru/toyota/?function=getModels&market=EU"); // по первой ссылке отправляем запрос

                var parsList = doc.QuerySelectorAll(".List");

            //List<int> list = new List<int>() { 1, 2, 2, 3, 2, 4, 1, 4, 5 };

            //List<int> distinct = parsList.Union(parsList).ToList();

            foreach (var item in parsList.Skip(1))
            {
                try
                {
                    Console.WriteLine(item.QuerySelector(".Header").TextContent);
                    Console.WriteLine(item.QuerySelector(".id").TextContent);
                    Console.WriteLine(item.QuerySelector(".modelCode").TextContent);
                    Console.WriteLine(item.QuerySelector(".dateRange").TextContent);
                }
                catch (Exception)
                {
                    
                } 
            }
         
            

                
            // выбираю откуда парсить
            //string a = "10.2016 -    ...";
            //string[] words = a.Split(new char[] { '.', '-' }, StringSplitOptions.RemoveEmptyEntries);
            //string fdf = null;
            //foreach (var item in words)
            //{
            //    fdf = "0" + $"{item}";
            //}
            //var url = "https://www.ilcats.ru/toyota/?function=getComplectations&market=EU&model=161230&startDate=197408&endDate=198107"; // сайт для парса

            //var config = Configuration.Default.WithDefaultLoader();

            //var context = BrowsingContext.New(config);

            //var doc = await context.OpenAsync(url);

            //var parsList = doc.QuerySelectorAll("td"); // выбираю откуда парсить

            //List<string> listConfiguration = new List<string>();

            //List<string> listConfiguration1 = new List<string>();

            //var configurationParse = doc.QuerySelectorAll("th");
            //foreach (var item in configurationParse.Take((configurationParse.Length) / 2 +1).Skip(2))
            //{
            //    listConfiguration.Add(item.TextContent);
            //}

            //foreach (var par in parsList.Take((configurationParse.Length) / 2 + 1).Skip(2))
            //{
            //    if (par.QuerySelector("div") != null)
            //    {
            //        listConfiguration1.Add(par.QuerySelector("div").TextContent);
            //    }
            //    else
            //    {
            //        listConfiguration1.Add(null);
            //    }
            //}

            //var keys = listConfiguration.ToArray();
            //var values = listConfiguration1.ToArray();

            // Dictionary<string, string> ConfigurationParse = keys
            // .Distinct()
            // .Select((key, i) => new {
            //     key,
            //     value = values[i % values.Length]
            // })
            // .ToDictionary(item => item.key, item => item.value);

            //Console.Write(string.Join(Environment.NewLine, result));
            ////try
            ////{

            ////}
            ////catch (Exception)
            ////{
            ////}

            //foreach (KeyValuePair<string, string> kvp in result)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}

        }
    }
    
}
