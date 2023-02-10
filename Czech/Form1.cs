using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            publicClass.pageLoad();
            dateTimePicker.Value = DateTime.Now;
        }
    }
}
