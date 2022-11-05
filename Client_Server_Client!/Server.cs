using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace Client_Server_Client_
{
    class Server
    {
        static TcpListener listener;
        static int port = 1000;
        static Currency currency;
        static List<TcpClientConnection> tcpClientConnections;
        static int count = 2; // limit connection
        
        //static event Action<string> MessageString;
        static void Main(string[] args)
        {
            currency = new Currency();
            tcpClientConnections = new List<TcpClientConnection>();
            Console.WriteLine("Я сервер и я запущен!");
            Console.WriteLine("Press ENTER to stop server...");
            currency.addCurrency();
            Task.Factory.StartNew(StartServer);
            Console.ReadLine();
        }
        static private bool CheckLogin(string _login, string _psw)
        {
            string login = "login";
            string psw = "password";

            if (login == _login && psw == _psw)
            {
                return true;
            }
            return false;
        }
        static private void StartServer()
        {
            
            listener = new TcpListener(IPAddress.Loopback, port);
            listener.Start(10);

            Console.WriteLine("Ожидаю подключения!");
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                //check login and password
                NetworkStream ns = client.GetStream();
                StringBuilder sb = new StringBuilder();
                int bytes = 0;
                byte [] buffer = new byte[200];
                do
                {
                    bytes = ns.Read(buffer, 0, buffer.Length);
                    sb.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
                } while (ns.DataAvailable);
                string[] logpass = sb.ToString().Split(' ');
                if (CheckLogin(logpass[0], logpass[1]))
                {
                    if (count != 3)// limit connection
                    {
                        Console.WriteLine($"Клиент подключился: {client.Client.RemoteEndPoint}");
                        TcpClientConnection tcpClientConnection = new TcpClientConnection(client);
                        tcpClientConnection.Disconect += TcpClientConnection_Disconect;
                        tcpClientConnection.IncomingMessage += TcpClientConnection_IncomingMessage;
                        tcpClientConnection.DoWorkAsync();
                        tcpClientConnections.Add(tcpClientConnection);
                        count++;
                    }
                    else
                    {
                        ns = client.GetStream();
                        buffer = Encoding.UTF8.GetBytes("limit");
                        ns.Write(buffer, 0, buffer.Length);
                        client.Client.Close();
                        Console.WriteLine("Server reached limit connection!");
                    }
                }
                else
                {
                    ns = client.GetStream();
                    buffer = Encoding.UTF8.GetBytes("wrong input");
                    ns.Write(buffer, 0, buffer.Length);
                    client.Client.Close();
                    Console.WriteLine($"Client:{client.Client.RemoteEndPoint}wrong input");
                }
            }
        }
        private static void TcpClientConnection_IncomingMessage(TcpClientConnection client, string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                Console.WriteLine($"Client: {client} - Disconect {DateTime.Now.ToLongTimeString()}");
                count--;
            }
            else
            {
            Console.WriteLine($"Client: {client} - Want Get Currency {message}");               
            }
        }

        private static void TcpClientConnection_Disconect(TcpClientConnection client)
        {
            if (tcpClientConnections.Contains(client))
                tcpClientConnections.Remove(client);
            Console.WriteLine($"Disconect {client} Time: {DateTime.Now.ToLongTimeString()}");
        }
    }
}
