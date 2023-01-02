using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace App_Lan_PingPong_UA
{
    public class Server
    {
        public Socket sck;
        public UdpClient udpServer;
        public TcpListener listener;
        public IPEndPoint remoteEP;

        public void StartLisnter()
        {
            udpServer = new UdpClient(1100);
            remoteEP = new IPEndPoint(IPAddress.Any, 1100);

            listener = new TcpListener(IPAddress.Any, 25655);
            listener.Start();
            sck = listener.AcceptTcpClient().Client;
        }
    }
}
