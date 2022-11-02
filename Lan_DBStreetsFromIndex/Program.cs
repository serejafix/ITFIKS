using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lan_DBStreetsFromIndex
{
    class Program
    {
        static int port = 8888; // порт сервера

        static void Main(string[] args)
        {
            ModelDBStrets dBStrets = new ModelDBStrets();
            Console.WriteLine("Привет я TCP сервер:)");

            // получаем адреса для запуска сокета
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

            // создаем сокет
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // связываем сокет с локальной точкой, по которой будем принимать данные
            listenSocket.Bind(ipPoint);

            // начинаем прослушивание
            listenSocket.Listen(10);

            Console.WriteLine("Я запущен. Ожиданию подключения)");
            while (true)
            {
                Socket handler = listenSocket.Accept();
                // получаем сообщение
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байтов
                byte[] data = new byte[256]; // буфер для получаемых данных

                do
                {
                    bytes = handler.Receive(data);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                
                while (handler.Available > 0);

                int i = int.Parse(builder.ToString());
                var select = from d in dBStrets.Indexes
                             from b in dBStrets.Streets
                             where d.Id == b.IndexId && d.Index1 == i
                             select b.Street1;

                // отправляем ответ
                foreach (var item in select)
                {                  
                    data = Encoding.Unicode.GetBytes(item);
                    handler.Send(data);
                }
                    
                    
                Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());
                // закрываем сокет
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
        }
    }
}
