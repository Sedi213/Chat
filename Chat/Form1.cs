using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Chat
{
    public partial class Form1 : Form
    {
        private static TcpListener listener;
        private TcpClient client = null;
        delegate void AddTextCallback(string text);
        private List<TcpClient> clients = new List<TcpClient>();
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
        }

     
        private void bntHost_Click(object sender, EventArgs e)
        {
            btnConnect.Visible=false;
            btnHost.Visible = false;
            textBox1.Visible = false;
            label1.Location = new Point(0, 0);
            label1.Text = "Server start";

            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
                listener.Start();

                Thread serverThread = new Thread(new ThreadStart(ServerStart));
                serverThread.Start();
            }finally { }
        }
        private void ServerStart()
        {
            while (true)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    clients.Add(client);
                }
                catch { break; }
                Thread clientThread = new Thread(new ParameterizedThreadStart(Process));
                clientThread.Start(clients.Count);
            }
        }

        private void Process(object IDclient1)
        {
            int id = (int)IDclient1 - 1;
            TcpClient localClient = clients[id];

            NetworkStream localStream = null;
            try
            {
                localStream = localClient.GetStream();
                byte[] data = new byte[256]; // буфер 
                while (true)
                {

                    AddTextSafe("\n");
                    int bytes = 0;
                    do
                    {
                        bytes = localStream.Read(data, 0, data.Length);
                        AddTextSafe(Encoding.Unicode.GetString(data, 0, bytes));

                    }
                    while (localStream.DataAvailable);

                    SendAllClientMSG();

                }
            }
            finally
            {
                if (localStream != null)
                    localStream.Close();
                if (localClient != null)
                    localClient.Close();
            }
        }


        private void SendAllClientMSG()
        {
            byte[] data = Encoding.Unicode.GetBytes(label1.Text);
            NetworkStream localStream = null;
            for (int i = 0; i < clients.Count; i++)
            {
                localStream = clients[i].GetStream();
                localStream.Write(data, 0, data.Length);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                listener.Stop();
            }
            catch { }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string address = textBox1.Text;
            btnConnect.Visible = false;
            btnHost.Visible = false;
            textBox1.Clear();
            textBox1.Location = new Point(10, 340);
            Send.Visible = true;
            label1.Text = "";
            label1.Location = new Point(0, 30);
            textBoxName.Visible = true;
            TimerUpdate.Enabled = true;

            try
            {
                client = new TcpClient(address, 8888);
                stream = client.GetStream();
            }
            finally { }

        }

        private void Send_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.Unicode.GetBytes(textBoxName.Text + " : " + textBox1.Text);
            stream.Write(data, 0, data.Length);
        }


        

        private void AddTextSafe(string text)
        {
            if (label1.InvokeRequired)
            {
                AddTextCallback d = new AddTextCallback(AddTextSafe);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label1.Text += text;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            byte[] data = new byte[256];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            while (stream.DataAvailable)
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
           
            if(builder.ToString()!="")
                label1.Text = builder.ToString();

        }
    }
}
