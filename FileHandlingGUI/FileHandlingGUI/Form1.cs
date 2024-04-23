using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHandlingGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str1 = textBox1.Text;
            FileStream fo = new FileStream(str1, FileMode.Create);
            StreamWriter sw = new StreamWriter(fo);
            Console.WriteLine("Enter a String. null for termination");
            String str = richTextBox1.ToString();
            sw.WriteLine(str);
            sw.Flush();
            fo.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

