using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

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

            publicClass.val = dateTimePicker.Value;

            #region مبلغ

            #region تبدیل به حروف

            if (!publicClass.InputValidator(txtMount.Text)) return;

            try
            {
                var digit = long.Parse(txtMount.Text);
                publicClass.Money_word = "";
                publicClass.Money_word = publicClass.ToAlphabet(digit);
                if (radioToman.Checked == true)
                {
                    publicClass.Money_word += " تومان";
                }
                else
                {
                    publicClass.Money_word += " ریال";
                }
                if (checkBox1.Checked == true)
                {
                    publicClass.Money_word += " تمام";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region تبدیل به عدد چاپ

            publicClass.C_PrintMoney();

            #endregion


            #endregion

            #region تاریخ

            #region تبدیل به حروف

            publicClass.Date_To_Word(dateTimePicker.Text);

            #endregion

            #region تبدیل به تاریخ چاپ

            publicClass.C_PrintDate();

            #endregion

            #endregion



            if (publicClass.NationalCode.Length != 10)
            {
                MessageBox.Show("کد یا شماره ملی باید 10 رقم باشد");
            }
            else
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }


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
            if (publicClass.Money != string.Empty) txtMount.Text = publicClass.Money;
            DateTime valu = DateTime.Parse("01 / 01 / 0001 12:00:00 ق.ظ");
            if (publicClass.val == valu)
            {
                publicClass.val = DateTime.Today;
            }
            dateTimePicker.Value = publicClass.val;


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

        }

    }
}
