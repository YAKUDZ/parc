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
            string command = $"main.py  \n {Movie}";

            ProcessStartInfo psi = new ProcessStartInfo();
            //Имя запускаемого приложения
            psi.FileName = "cmd";
            //команда, которую надо выполнить
            psi.Arguments = @"CMD /k" + command ; 
            Process.Start(psi);

        }
    }
}
