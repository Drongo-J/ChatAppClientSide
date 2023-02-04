using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ChatAppClientSide.Helpers;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace ChatAppClientSide.Services.NetworkServices
{
    public class NetworkServices
    {
        private static BinaryReader reader = null;
        private static BinaryWriter writer = null;

        public static TcpClient Client { get; set; }

        public static string Message = "";

        public static void ConnectToServer()
        {
            Client = new TcpClient();

            var ipAdress = IPAddress.Parse(NetworkHelpers.GetLocalIpAddress());
            var port = NetworkConstants.PORT;

            var ep = new IPEndPoint(ipAdress, port);

            //MessageBoxHelpers.ShowInformationAsync($"Connected to Server");

            while (true)
            {
                Client.Connect(ep);
                try
                {
                    if (Client.Connected)
                    {
                        Thread sendThread = new Thread(new ThreadStart(Send));
                        Thread receiveThread = new Thread(new ThreadStart(Receive));
                        sendThread.Start();
                        receiveThread.Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        static void Send()
        {
            var stream = Client.GetStream();
            Task.Run(() =>
            {
                while (true)
                {
                    writer = new BinaryWriter(stream);
                    if (Message != String.Empty)
                    {
                        writer.Write(Message);
                        Message = String.Empty;
                    }
                }
            });
        }

        static void Receive()
        {
            var stream = Client.GetStream();
            Task.Run(() =>
            {
                while (true)
                {
                    reader = new BinaryReader(stream);
                    var message = reader.ReadString();
                    if (message != String.Empty)
                    {
                        App.IntegrateMessageToView(message);
                    }
                }
            });
        }
    }
}
