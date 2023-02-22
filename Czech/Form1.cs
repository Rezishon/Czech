using FarsiLibrary.Win.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using FarsiLibrary;
using System.Threading;
using FarsiLibrary.Utils;

namespace Czech
{
    public partial class Form1 : Form
    {
        PublicClass publicClass = new PublicClass();        
        FADatePicker fADatePicker = new FADatePicker();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            publicClass.Date = fADatePicker.Text;

            string[] str = new string[4];
            string Str = string.Empty;
            if (txtMount.Text.Contains(","))
            {
                str = txtMount.Text.Split(',');
                foreach (string item in str)
                {
                    Str += item;
                }
                publicClass.Money = Str;
            }
            else
            {
                publicClass.Money = txtMount.Text;
            }


            publicClass.For = txtFor.Text;
            publicClass.NationalCode = txtCode.Text;

            publicClass.val = fADatePicker.Text;

            if (String.IsNullOrEmpty(txtFor.Text))
            {
                MessageBox.Show("لطفا قسمت در وجه را پر کنید");
            }
            else
            {
                if (txtCode.Text.Length != 10 && txtCode.Text.Length > 0)
                {
                    MessageBox.Show("کد ملی باید 10 رقم باشد");
                }
                else
                {
                    if (fADatePicker.Text == "[هیج مقداری انتخاب نشده]")
                    {
                        MessageBox.Show("لطفا تاریخی را انتخاب کنید");
                    }
                    else
                    {
                        #region مبلغ

                        #region تبدیل به حروف

                        if (!publicClass.InputValidator(txtMount.Text)) return;

                        try
                        {
                            var digit = long.Parse(publicClass.Money);
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

                        publicClass.Date_To_Word(fADatePicker.Text);

                        #endregion

                        #region تبدیل به تاریخ چاپ


                        publicClass.Date_Print = publicClass.C_PrintDate(fADatePicker.Text);

                        #endregion

                        #endregion

                        Menu menu = new Menu();
                        this.Hide();
                        menu.Show();
                    }
                }
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

            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            if (fADatePicker.Text == "[Empty Value]")
            {
                
                fADatePicker.Text = $"{PersianDate.Now.Year}/";
                fADatePicker.Text += PersianDate.Now.Month.ToString().Length < 2 ? $"0{PersianDate.Now.Month}/" : $"{PersianDate.Now.Month}/";
                fADatePicker.Text += PersianDate.Now.Day.ToString().Length < 2 ? $"0{PersianDate.Now.Day}" : $"{PersianDate.Now.Day}";
            }
            else
            {
                fADatePicker.Text = publicClass.val;
            }

            fADatePicker.Location = new Point(13, 12);
            Font font = new Font("2  Titr", 10, FontStyle.Bold);
            fADatePicker.Font = font;
            Size size = new Size(108, 30);
            fADatePicker.Size = size;
            fADatePicker.RightToLeft = RightToLeft.No;

            this.Controls.Add(fADatePicker);

            if (publicClass.ON)
            {
                Load_Page load_Page = new Load_Page();
                load_Page.Show();
                System.Threading.Thread.Sleep(5000);
                load_Page.Close();
            }
            publicClass.ON = false;

            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Resources\\image2.jpg"))
            {
                DialogResult dialog = MessageBox.Show($"لطفا تصویر چک خود را با ابعاد دقیق ،به میلی متر یا سانتی متر ،در آدرس \n\"{Directory.GetCurrentDirectory() + "\\Resources"}\" \nو با نام \n\"image2.jpg\" \nذخیره نمایید.", "خطا عدم وجود تصویر چک", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dialog == DialogResult.Retry) Form1_Load(sender, e);
                else Application.Exit();
            }
            if (publicClass.Money != string.Empty) txtMount.Text = publicClass.Money;
            if (publicClass.For != string.Empty) txtFor.Text = publicClass.For;
            if (publicClass.NationalCode != string.Empty) txtCode.Text = publicClass.NationalCode;


            Dictionary<string, int> list;
            list = publicClass.File_List;
            if (File.Exists(publicClass.File_Path) == false)
            {
                MessageBox.Show($"لطفا تصویر چک خود را با ابعاد دقیق ،به میلی متر یا سانتی متر ،در آدرس \n\"{Directory.GetCurrentDirectory() + "\\Resources"}\" \nو با نام \n\"image2.jpg\" \nذخیره نمایید.", "تعویض تصویر چک", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);


                File.WriteAllText(publicClass.File_Path, "");
                publicClass.SaveTextFile("669", list["Length"]);
                publicClass.SaveTextFile("335", list["Width"]);
                publicClass.SaveTextFile("10", list["DateInNum_X"]);
                publicClass.SaveTextFile("10", list["DateInNum_Y"]);
                publicClass.SaveTextFile("Arial,12,Bold", list["DateInNum_Font"]);
                publicClass.SaveTextFile("10", list["DateInWord_X"]);
                publicClass.SaveTextFile("30", list["DateInWord_Y"]);
                publicClass.SaveTextFile("Arial,12,Bold", list["DateInWord_Font"]);
                publicClass.SaveTextFile("true", list["DateInWord_Enable"]);
                publicClass.SaveTextFile("10", list["MoneyInWord_X"]);
                publicClass.SaveTextFile("50", list["MoneyInWord_Y"]);
                publicClass.SaveTextFile("Arial,12,Bold", list["MoneyInWord_Font"]);
                publicClass.SaveTextFile("10", list["For_X"]);
                publicClass.SaveTextFile("70", list["For_Y"]);
                publicClass.SaveTextFile("Arial,12,Bold", list["For_Font"]);
                publicClass.SaveTextFile("10", list["NationalCode_X"]);
                publicClass.SaveTextFile("90", list["NationalCode_Y"]);
                publicClass.SaveTextFile("Arial,12,Bold", list["NationalCode_Font"]);
                publicClass.SaveTextFile("true", list["NationalCode_Enable"]);
                publicClass.SaveTextFile("10", list["MoneyInNum_X"]);
                publicClass.SaveTextFile("110", list["MoneyInNum_Y"]);
                publicClass.SaveTextFile("Arial,12,Bold", list["MoneyInNum_Font"]);
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

        private void txtMount_TextChanged(object sender, EventArgs e)
        {
            txtMount.Text = publicClass.CammaInMoney(txtMount.Text);
            txtMount.SelectionStart = txtMount.Text.Length;
        }

    }
}
