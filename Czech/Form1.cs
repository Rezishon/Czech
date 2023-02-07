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

            // sql commands:
            // {

            // }


            // make a new form is wrong should use pointers to show and close that form
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
