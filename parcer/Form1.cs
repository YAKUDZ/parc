using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Net.Http.Headers;

namespace parcer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputToCmd(textBox1.Text);
        }

        private void OutputToCmd(string Movie )
        { 
            //string command = $"cd D:Parser\\utils python request_query.py  {Movie}";

            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
            //Имя запускаемого приложения
            //psi.FileName = "cmd";
            //команда, которую надо выполнить
            psi.Arguments = $"CMD /k cd D:Parser\\utils && python request_query.py && CMD /k {Movie}";
            Process.Start(psi);           
        } 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //cd D:Parser\\utils \n python request_query.py  \n {Movie}
        // "CMD /k cd D:Parser\\utils  \"python request_query.py\""
    }
}
