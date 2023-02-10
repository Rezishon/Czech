using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Czech
{
    public partial class Text_Setting : Form
    {
        public Text_Setting()
        {
            InitializeComponent();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnFont1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
