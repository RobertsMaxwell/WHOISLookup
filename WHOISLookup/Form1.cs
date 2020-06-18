using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHOISLookup
{
    public partial class Form1 : Form
    {
        public static string address;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            address = domainText.Text;
            Console.WriteLine(GetWhoIsServer(address));
            PopulateDisplay(new WhoIsReponse("whois.verisign-grs.com", address).queryResults);
        }

        public void PopulateDisplay(List<string> entries)
        {
            listBox1.Items.Clear();
            foreach (string entry in entries)
            {
                listBox1.Items.Add(entry);     
            }
        }

        public string GetWhoIsServer(string address)
        { 
            
        }
    }
}
