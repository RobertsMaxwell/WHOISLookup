using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace WHOISLookup
{
    static class Lookup
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/

            WHOISLookup();
        }

        public static void WHOISLookup()
        {
            TcpClient client = new TcpClient("whois.verisign-grs.com", 43);
            Console.WriteLine(client.GetStream().Length);
        }
    }
}
