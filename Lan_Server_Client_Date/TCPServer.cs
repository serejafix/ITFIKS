using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lan_Server_Client_Date
{
    class TCPServer
    {
        static int port = 8888; // порт сервера

        static void Main(string[] args)
        {
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

                if (builder.ToString().ToLower() == "дата") // отправляем ответ по дате
                {
                    // отправляем ответ
                    string message = DateTime.Now.ToShortDateString();
                    data = Encoding.Unicode.GetBytes(message);
                    handler.Send(data);
                }
                else if (builder.ToString().ToLower() == "время")// отправляем ответ по времени
                {
                    // отправляем ответ
                    string message = DateTime.Now.ToShortTimeString();
                    data = Encoding.Unicode.GetBytes(message);
                    handler.Send(data);
                }
                else
                {
                    // отправляем ответ
                    string message = "Проверьте правильность ввода:), с уважением tcp сервер)";
                    data = Encoding.Unicode.GetBytes(message);
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
