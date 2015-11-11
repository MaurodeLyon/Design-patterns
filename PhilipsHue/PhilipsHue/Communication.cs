using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PhilipsHue
{
    class Communication
    {
        public static void SendString(TcpClient client, string message)
        {
            StreamWriter stream = new StreamWriter(client.GetStream(), Encoding.Unicode);
            stream.WriteLine(message);
            stream.Flush();
        }

        public static string ReadString(TcpClient client)
        {
            StreamReader stream = new StreamReader(client.GetStream(), Encoding.Unicode);
            return stream.ReadLine();
        }
    }
}
