using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using System.Net.Http;
using System.Net;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            string html = http.Get("https://google.vn/").ToString();
            var request = (HttpWebRequest)WebRequest.Create("http://www.example.com/recepticle.aspx");
            MessageBox.Show(html);
        }
    }
}
