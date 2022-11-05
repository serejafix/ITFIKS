using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CLient
{
    public partial class Form1 : Form
    {
        //static int port = 8888; // порт сервера
        //static string address = "127.0.0.1"; // адрес сервера
        static byte[] data;
        static string message;
        static Socket socket;

        public Form1()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

        }
        private void button_Connect_Click(object sender, EventArgs e)
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(textBox_Ip.Text), Convert.ToInt32(textBox_Port.Text));          
            socket.Connect(ipPoint);
        }

        private void button__Send_Click(object sender, EventArgs e)
        {
            data = Encoding.Unicode.GetBytes(textBox_Index.Text);
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
            var res = Regex.Split(builder.ToString(), "(?=\\p{Lu})");
            res = res.Skip(1).ToArray();
            for (int i = 0; i < res.Length; i++)
            {
                listBox_ListStreets.Items.Add(res[i]);
            }           
            // закрываем сокет
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        private void textBox_Ip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
