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
        PublicClass publicClass = new PublicClass();

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
            publicClass.SaveTextFile(txtLength.Text, publicClass.File_List["Length"]);
            publicClass.SaveTextFile(txtWidth.Text, publicClass.File_List["Width"]);
            MessageBox.Show("ذخیره شد","Save");
        }

        private void Page_Setting_Load(object sender, EventArgs e)
        {
            publicClass.pageLoad();
            txtLength.Text = publicClass.File_Text[publicClass.File_List["Length"]];
            txtWidth.Text = publicClass.File_Text[publicClass.File_List["Width"]];
        }

    }
}
