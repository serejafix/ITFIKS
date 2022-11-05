using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server_Client_
{
    class TcpClientConnection
    {
        TcpClient client;
        static Server program;
        static Currency currency;
        public event Action<TcpClientConnection> Disconect;
        public event Action<TcpClientConnection,string> IncomingMessage;
        static int count = 0;
        static int countSending = 0;
        public int ID { get; set; }
        public TcpClientConnection(TcpClient client)
        {
            currency = new Currency();
            currency.addCurrency();
            ID = ++count;
            this.client = client;
        }
        public override string ToString()
        {
            return $"Connection{ID}";
        }
        public Task DoWorkAsync() => Task.Run(DoWork);

        public void DoWork()
        {           
            if (!client.Connected || client == null)
                return;
            NetworkStream ns = client.GetStream();
            int bytes = 0;
            byte[] buffer = new byte[256];
            StringBuilder sb = new StringBuilder();
            while (true)
            {  
                    do
                    {
                        bytes = ns.Read(buffer, 0, buffer.Length);
                        sb.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
                    } while (ns.DataAvailable);
                    string[] twoCurrency = sb.ToString().Split(' ');
                    IncomingMessage?.Invoke(this, sb.ToString());
                    countSending++;
                    buffer = Encoding.UTF8.GetBytes(currency.GetCurrency(twoCurrency[0], twoCurrency[1]).ToString());
                    ns.Write(buffer, 0, buffer.Length);
                    sb.Clear();
            }
        }
    }
}
