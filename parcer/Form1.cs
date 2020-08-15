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
using System.IO;

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
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.CreateNoWindow =  true;
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = $"CMD /k cd Parser\\utils && chcp 65001 && CMD /c python request_query.py {Movie}";
            p.Start();
            p.StandardOutput.ReadLine();
            string output = p.StandardOutput.ReadLine() + "\n";
            output += p.StandardOutput.ReadLine();
            p.Close();
            label2.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindMovie(textBox2.Text, textBox3.Text, comboBox1.SelectedIndex);
        }

        private void FindMovie(string kinid, string imdbid, int index)
        {
            string type;
            if(index == 1)
            {
                type = "movie";
            }
            else
            {
                type = "series";
            }
            
            Process p = new Process();
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = $"CMD /k cd Parser && python main.py {kinid} {imdbid} {type}";
            p.Start();
        }
    }
}
