using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Czech
{
    public partial class Page_Setting : Form
    {
        static string file_path = Directory.GetCurrentDirectory() + "\\Resources\\File.txt";
        string[] file_text = new string[8];

        public Page_Setting()
        {
            InitializeComponent();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            file_text[0] = txtHeight.Text;
            file_text[1] = txtWidth.Text;

            saveToFile();
            MessageBox.Show("ذخیره شد","Save");
        }

        private void Page_Setting_Load(object sender, EventArgs e)
        {
            if (File.Exists(file_path) == false)
            {
                File.WriteAllText(file_path, "");

                file_text[0] = "899";
                file_text[1] = "444";

                saveToFile();
                Page_Setting_Load(null, null);
            }
            else
            {
                file_text = File.ReadAllLines(file_path);

                txtHeight.Text = file_text[0];
                txtWidth.Text = file_text[1];
            }
            txtWidth.Focus();
        }
        
        public void saveToFile()
        {
            File.WriteAllText(file_path, "");
            foreach (string line in file_text)
            {
                File.AppendAllText(file_path, line + Environment.NewLine);
            }
        }

    }
}
