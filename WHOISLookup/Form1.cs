using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace WHOISLookup
{
    public partial class Maxwell : Form
    {
        public static string address;

        public Maxwell()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            address = CleanAddress(domainText.Text);

            if (address.Where(c => c == '.').Count() < 1)
            {
                MessageBox.Show("Please enter a valid domain name", "Error", MessageBoxButtons.OK);
                return;
            }

            if (address.Contains(".uk"))
            {
                MessageBox.Show(".uk TLD's are not supported.", "Error", MessageBoxButtons.OK);
            }

            try
            {
                PopulateDisplay(new WhoIsReponse("whois.iana.org", address).queryResults);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
                return;
            }

        }

        public void PopulateDisplay(List<string> entries)
        {
            listBox1.Items.Clear();
            foreach (string entry in entries)
            {
                listBox1.Items.Add(entry);
            }
        }

        public string CleanAddress(string address)
        {
            address = address.Trim().ToLower();
            address = address.Replace(@"\", "");
            address = address.Replace("/", "");
            address = address.Replace("https:", "");
            address = address.Replace("www.", "");
            return address;
        }

    }
}
