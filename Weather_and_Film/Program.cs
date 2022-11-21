using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Weather_and_Film
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            Console.ReadLine();
        }
        static private void PrintMenu()
        {
            Console.WriteLine("Сделайте выбор");
            Console.WriteLine("1. Погода");
            Console.WriteLine("2. Фильм");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Введите город");
                    string city = Console.ReadLine();
                    GetWeather(city);
                    break;
                case 2:
                    Console.WriteLine("Введите фильм");
                    string film = Console.ReadLine();
                    GetFilm(film);
                    break;
                default:
                    break;
            }
        }
        static private void GetFilm(string filmName)
        {
            string url = $"https://www.omdbapi.com/?t={filmName}&plot=full&apikey=8312d2d9";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse HttpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader reader = new StreamReader(HttpWebResponse.GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }
            FilmResponse film = JsonConvert.DeserializeObject<FilmResponse>(response);

            Console.WriteLine($"Film -> {film.title} - Genre -> {film.genre} - Year -> {film.year} - Released -> {film.released}");
        }
        // всё сделал правильно, забираю температуру которая пришла, но видимо с сайтов что то не так, 280 градусов пишет) хотя не должно,других параметров нету)
        static private void GetWeather(string cityname)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityname}&appid=50dba4690cdab1e9a27db8ed8e6c7b20";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse HttpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader reader = new StreamReader(HttpWebResponse.GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }
            WeatherResponse weather = JsonConvert.DeserializeObject<WeatherResponse>(response);

            Console.WriteLine("Temperature in {0}: {1} °C", weather.Name, weather.Main.Temp);
        }
    }
}
