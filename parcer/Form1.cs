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
using System.Runtime.Serialization.Json;
using System.Data.Linq;

namespace parcer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        //tab 1
        private void button1_Click(object sender, EventArgs e)
        {
            OutputToCmd(textBox1.Text);
        }

        private void OutputToCmd(string Movie )
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow =  true;
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = $"CMD /k cd Parser\\utils && chcp 65001 && CMD /c python request_query.py {Movie}";
            p.Start();
            //пропуск первой строки ибо там ответ кодировки и он не нужен
            p.StandardOutput.ReadLine();
            //построчное считывание консоли, ибо если запустить ReadToEnd, то прога будет висеть.
            string output = p.StandardOutput.ReadLine() + "\n";
            output += p.StandardOutput.ReadLine();
            p.Close();
            label2.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindMovie(textBox2.Text, textBox3.Text, comboBox1.SelectedIndex);
        }

        private void FindMovie(string kinid, string tmdbid, int index)
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
            p.StartInfo.Arguments = $"CMD /k cd Parser && python main.py 41519, 20992,  \'movie\'";
            p.Start();
        }

        //tab2
        private void button3_Click(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            switch (index)
            {
                case 0:
                    jsonMoviereader();
                    break;
                case 1:
                    jsonSeriesreader();
                    break;
                case 2:
                    jsonPersonreader();
                    break;
                default:
                    break;
            
            }
        }
        private void jsonPersonreader()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));

            FileStream reader = new FileStream("13122.json",FileMode.Open);
            reader.Position = 0;
            Person person = (Person)serializer.ReadObject(reader);
            reader.Close();

            label5.Text = person.id.ToString(); ;
        }

        private void jsonMoviereader()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Movie));

            FileStream reader = new FileStream("1e11e57df1b99623.json", FileMode.Open);
            reader.Position = 0;
            Movie movie = (Movie)serializer.ReadObject(reader);
            reader.Close();

            label5.Text = movie.id.ToString();
        }
        
        private void jsonSeriesreader()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Series));

            FileStream reader = new FileStream("info.json", FileMode.Open);
            reader.Position = 0;
            Series series = (Series)serializer.ReadObject(reader);
            reader.Close();

            label5.Text = series.id.ToString();
        }
    }
}
