using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Czech
{
    public partial class Page_Setting : Form
    {
        public Page_Setting()
        {
            InitializeComponent();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
        }
    }
}
