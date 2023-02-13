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

            if (String.IsNullOrEmpty(txtFor.Text))
            {
                MessageBox.Show("لطفا قسمت در وجه را پر کنید");
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
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Resources\\image2.jpg"))
            {
                DialogResult dialog = MessageBox.Show($"لطفا تصویر چک خود را با ابعاد دقیق ،به میلی متر یا سانتی متر ،در آدرس \n\"{Directory.GetCurrentDirectory() + "\\Resources"}\" \nو با نام \n\"image.jpg\" \nذخیره نمایید.", "خطا عدم وجود تصویر چک", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dialog == DialogResult.Retry) Form1_Load(sender, e);
            }
            if (publicClass.Money != string.Empty) txtMount.Text = publicClass.Money;
            if (publicClass.For != string.Empty) txtFor.Text = publicClass.For;
            if (publicClass.NationalCode != string.Empty) txtCode.Text = publicClass.NationalCode;

            DateTime valu = DateTime.Parse("01 / 01 / 0001 12:00:00 ق.ظ");
            if (publicClass.val == valu) publicClass.val = DateTime.Today;
            dateTimePicker.Value = publicClass.val;

            Dictionary<string, int> list;
            list = publicClass.File_List;
            if (File.Exists(publicClass.File_Path) == false)
            {
                File.WriteAllText(publicClass.File_Path, "");
                publicClass.SaveTextFile("669", list["Length"]);
                publicClass.SaveTextFile("335", list["Width"]);
                publicClass.SaveTextFile("0", list["DateInNum_X"]);
                publicClass.SaveTextFile("5", list["DateInNum_Y"]);
                publicClass.SaveTextFile("Microsoft Sans Serif,8/25,Regular", list["DateInNum_Font"]);
                publicClass.SaveTextFile("0", list["DateInWord_X"]);
                publicClass.SaveTextFile("25", list["DateInWord_Y"]);
                publicClass.SaveTextFile("Microsoft Sans Serif,8/25,Regular", list["DateInWord_Font"]);
                publicClass.SaveTextFile("true", list["DateInWord_Enable"]);
                publicClass.SaveTextFile("0", list["MoneyInWord_X"]);
                publicClass.SaveTextFile("45", list["MoneyInWord_Y"]);
                publicClass.SaveTextFile("Microsoft Sans Serif,8/25,Regular", list["MoneyInWord_Font"]);
                publicClass.SaveTextFile("0", list["For_X"]);
                publicClass.SaveTextFile("65", list["For_Y"]);
                publicClass.SaveTextFile("Microsoft Sans Serif,8/25,Regular", list["For_Font"]);
                publicClass.SaveTextFile("0", list["NationalCode_X"]);
                publicClass.SaveTextFile("85", list["NationalCode_Y"]);
                publicClass.SaveTextFile("Microsoft Sans Serif,8/25,Regular", list["NationalCode_Font"]);
                publicClass.SaveTextFile("true", list["NationalCode_Enable"]);
                publicClass.SaveTextFile("0", list["MoneyInNum_X"]);
                publicClass.SaveTextFile("105", list["MoneyInNum_Y"]);
                publicClass.SaveTextFile("Microsoft Sans Serif,8/25,Regular", list["MoneyInNum_Font"]);
                publicClass.SaveTextFile("true", list["Date_Enable"]);
            }
            try
            {
                publicClass.pageLoad();
                publicClass.PageHeight = publicClass.File_Text[list["Length"]];
                publicClass.PageWidth = publicClass.File_Text[list["Width"]];
                publicClass.Image_path = Directory.GetCurrentDirectory() + "\\Resources\\image2.jpg";
                publicClass.Czech_Image = Image.FromFile(publicClass.Image_path);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

    }
}
