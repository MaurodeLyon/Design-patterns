using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhilipsHue
{
    class InternetBridge
    {
        TcpListener listener;
        public InternetBridge()
        {
            IPAddress ip = IPAddress.Any;
            listener = new TcpListener(ip, 2525);
            listener.Start();
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                new Thread(receiveConnection).Start(client);
            }
        }

        private void receiveConnection(object obj)
        {
            TcpClient client = obj as TcpClient;
            LampSturing lamp = new LampSturing(client);
            while (client.Connected)
            {
                string incomingData = Communication.ReadString(client);
                string[] splitData = incomingData.Split('|');
                // setLightState(id, bri, hue, sat);
                // 1|id|bri|hue|sat
                switch (splitData[0])
                {
                    case "1":
                        lamp.setLightState(splitData[1], splitData[2], splitData[3], splitData[4]);
                        break;
                    default:
                        break;
                }
                 // receive incoming command and process command
            }
        }
    }
}
