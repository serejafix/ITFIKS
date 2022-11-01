using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCP_Client_1
{
    class TCPClient
    {
        static int port = 8888; // порт сервера
        static string address = "127.0.0.1"; // адрес сервера

        static void Main(string[] args)
        {
            Console.WriteLine("Привет, Я клиент:)");
            do
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipPoint);
                byte[] data;
                string message;
                Console.Write("Введите сообщение:");
                message = Console.ReadLine();

                data = Encoding.Unicode.GetBytes(message);
                socket.Send(data);
                data = new byte[256]; // буфер для ответа
                                      // получаем ответ
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байт

                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);
                Console.WriteLine("ответ сервера: " + builder.ToString());

                // закрываем сокет
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            } while (true);
            // подключаемся к удаленному хосту
               
        }
        
    }
}
