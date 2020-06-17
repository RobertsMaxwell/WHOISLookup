using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace WHOISLookup
{
    class WhoIsReponse
    {
        List<string> queryResults = new List<string>();

        public WhoIsReponse(string whoIsServer, string domain)
        {
            //check for registrar whois server
            foreach (string info in SendQuery(whoIsServer, domain).Split('\n'))
            {
                if (info.Contains("Registrar WHOIS Server:"))
                {
                    whoIsServer = info.Substring(info.IndexOf(':') + 1, info.Length - (info.IndexOf(':') + 1));
                }
            }

            queryResults = SendQuery(whoIsServer, domain).Split('\n').ToList();
        }

        public static string SendQuery(string whoIsServer, string domain)
        {
            string log = "";

            TcpClient client = new TcpClient(whoIsServer, 43);
            NetworkStream netStream = client.GetStream();
            byte[] domainByte = Encoding.ASCII.GetBytes(domain + "\n");
            netStream.Write(domainByte, 0, domainByte.Length);
            StreamReader reader = new StreamReader(client.GetStream(), Encoding.ASCII);

            do
            {
                log += (char)reader.Read();
            } while (netStream.DataAvailable);

            return log;
        }
    }
}