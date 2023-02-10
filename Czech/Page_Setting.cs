﻿using System;
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
        PublicClass publicClass = new PublicClass();
        // Print Class:
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
            publicClass.SaveTextFile(txtLength.Text,0);
            publicClass.SaveTextFile(txtWidth.Text, 1);
            MessageBox.Show("ذخیره شد","Save");
        }

        private void Page_Setting_Load(object sender, EventArgs e)
        {
            publicClass.pageLoad();
            txtLength.Text = publicClass.File_Text[0];
            txtWidth.Text = publicClass.File_Text[1];
        }

        // Page Class:
        public void saveToFile()
        {
            File.WriteAllText(publicClass.File_Path, "");
            foreach (string line in publicClass.File_Text)
            {
                File.AppendAllText(publicClass.File_Path, line + Environment.NewLine);
            }
        }

    }
}
