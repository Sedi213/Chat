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
using System.Xml.Serialization;

namespace Chat
{
    public partial class Form1 : Form
    {
      
        private TcpClient client;
        private NetworkStream stream;
        private string NameUser;
        private Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            MSGTextBox.Enabled = true;
            NameTB.Enabled = false;
            IpTB.Enabled = false;
            NameUser = NameTB.Text;
            btnConnect.Text = "Disconect";

            try
            {
                client = new TcpClient(IpTB.Text, 8888);
                stream = client.GetStream();

                byte[] data = Encoding.ASCII.GetBytes(NameUser + " Connect");
                stream.Write(data, 0, data.Length);

                thread = new Thread(new ThreadStart(Listening));
                thread.Start();
            }
            catch
            {
                LBText.Items.Add("failed to connect to the server");
            }
        }
        private void Disconnect()
        {
            MSGTextBox.Enabled = false;
            NameTB.Enabled = true;
            IpTB.Enabled = true;
            btnConnect.Text = "Connect";

            

            byte[] data = Encoding.ASCII.GetBytes(NameUser + " Disconnect");
            stream.Write(data,0,data.Length);

            thread.Abort();
            client.Close();
            stream.Close();

        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {

            if (btnConnect.Text=="Connect") 
                Connect();
            else 
                Disconnect();
        }



        private void MSGTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                byte[] data=Encoding.ASCII.GetBytes(NameUser+" : "+ MSGTextBox.Text);
                stream.Write(data, 0, data.Length);
                MSGTextBox.Clear();
            }
        }

        private void Listening()
        {       
            while (true)
            {
                byte[] data = new byte[1024];
                stream.Read(data, 0, data.Length);
                LBText.Items.Add(Encoding.ASCII.GetString(data));
            }
        }
    }
}
