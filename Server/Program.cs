using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace  Server
{
    internal class Program
    {
        static List<TcpClient> clients;
        static void Main(string[] args)
        {
            try
            {
                TcpListener server = new TcpListener(System.Net.IPAddress.Any, 8888);
                server.Start();
                clients = new List<TcpClient>();


                while (true)
                {
                    clients.Add(server.AcceptTcpClient()); 
     
                    Thread clientThread = new Thread(new ParameterizedThreadStart(Process));
                    clientThread.Start(clients.Count);

                }

               
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
                
            }
        }

        private static void Process(object IDclient)
        {
            int id = (int)IDclient - 1;
            TcpClient localClient = clients[id];

            NetworkStream localstream = localClient.GetStream();
            try
            {
        
                while (true)
                { 
                    byte[] data = new byte[1024];
                    localstream.Read(data, 0, data.Length);

                    foreach(var client in clients)
                    {
                        NetworkStream steam = client.GetStream();
                        steam.Write(data, 0, data.Length);
                    }
                 
                    if (Encoding.ASCII.GetString(data).Contains("Disconnect"))
                        break;
                }
            }
            finally
            {
                if (localstream != null)
                    localstream.Close();
                if (localClient != null)
                    localClient.Close();
                clients.Remove(clients.Find(x=>x==localClient));
            }
        }

    }

}