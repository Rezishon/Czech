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
    public partial class Form1 : Form
    {
        PublicClass publicClass = new PublicClass();        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            publicClass.Date = dateTimePicker.Text;
            publicClass.Money = txtMount.Text;
            publicClass.For = txtFor.Text;
            publicClass.NationalCode = txtCode.Text;

            //if (publicClass.Date == string.Empty || publicClass.Money == string.Empty || publicClass.For == string.Empty || publicClass.NationalCode == string.Empty)
            //{
            //    MessageBox.Show("لطفا اطلاعات را تکمیل کنید");
            //}
            //else
            //{
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            //}

            
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            publicClass.intOnly(e);
        }

        private void txtHeitht_KeyPress(object sender, KeyPressEventArgs e)
        {
            publicClass.doubleOnly(e);
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            publicClass.intOnly(e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> list;
            list = publicClass.File_List;
            if (File.Exists(publicClass.File_Path) == false)
            {
                File.WriteAllText(publicClass.File_Path, "");
                publicClass.SaveTextFile("899", list["Length"]);
                publicClass.SaveTextFile("444", list["Width"]);
                publicClass.SaveTextFile("true", list["DateInWord_Enable"]);
                publicClass.SaveTextFile("true", list["NationalCode_Enable"]);
            }
            publicClass.pageLoad();
            publicClass.PageHeight = publicClass.File_Text[list["Length"]];
            publicClass.PageWidth = publicClass.File_Text[list["Width"]];
            publicClass.Image_path = Directory.GetCurrentDirectory() + "\\Resources\\image2.jpg";
            publicClass.Czech_Image = Image.FromFile(publicClass.Image_path);
            dateTimePicker.Value = DateTime.Now;

        }
    }
}
