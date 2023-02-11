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
            publicClass.SaveTextFile(publicClass.inch_To_100(publicClass.string_To_Double(txtLength.Text)).ToString(), publicClass.File_List["Length"]);
            publicClass.SaveTextFile(publicClass.inch_To_100(publicClass.string_To_Double(txtWidth.Text)).ToString(), publicClass.File_List["Width"]);
            MessageBox.Show("ذخیره شد","Save");
        }

        private void Page_Setting_Load(object sender, EventArgs e)
        {
            publicClass.pageLoad(); 
                
            txtLength.Text = publicClass.inch_To_100_X(publicClass.string_To_Double_X(publicClass.File_Text[publicClass.File_List["Length"]])).ToString();
            txtWidth.Text = publicClass.inch_To_100_X(publicClass.string_To_Double_X(publicClass.File_Text[publicClass.File_List["Width"]])).ToString();
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            publicClass.intOnly(e);
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            publicClass.intOnly(e);
        }
    }
}
