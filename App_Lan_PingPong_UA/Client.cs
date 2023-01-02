using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace App_Lan_PingPong_UA
{
    public class Client
    {
        public IPEndPoint ep;
        public UdpClient udpclient;
        public IPEndPoint remoteEP;
        public TcpClient client;

        public void Start(string _ip)
        {
            remoteEP = new IPEndPoint(IPAddress.Any, 0);
            client = new TcpClient();
            client.Connect(_ip, 25655);

            udpclient = new UdpClient();
            ep = new IPEndPoint(IPAddress.Parse(_ip), 1100);
            udpclient.Connect(ep);
        }
    }
}
