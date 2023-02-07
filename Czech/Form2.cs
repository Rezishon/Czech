using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Czech
{
    public partial class Form2 : Form
    {
        static string file_path = Directory.GetCurrentDirectory() + "\\Resources\\File.txt";
        string[] file_text = new string[8];

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists(file_path) == false)
            {
                // do some
                File.WriteAllText(file_path, "");

                Form2_Load(null, null);

            }
            else
            {
                file_text = File.ReadAllLines(file_path);
                foreach (string line in file_text)
                {
                    textBox1.Text += line + Environment.NewLine;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (string line in file_text)
            {
                textBox1.Text += line + Environment.NewLine;
            }
            Form2_Load(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            file_text[4] = textBox1.Text;
            textBox1.Text = "";

            File.WriteAllText(file_path, "");
            foreach (string line in file_text)
            {
                File.AppendAllText(file_path, line + Environment.NewLine);
            }
               
        }

    }
}
