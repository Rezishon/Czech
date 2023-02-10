using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Czech
{
    public partial class Text_Setting : Form
    {
        PublicClass publicClass = new PublicClass();
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
            Font font = fontDialog1.Font;
            MessageBox.Show(font.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            publicClass.SaveTextFile(txtDateInNum1.Text, 2);
            publicClass.SaveTextFile(txtDateInNum2.Text, 3);
            publicClass.SaveTextFile(txtDateInWord1.Text, 5);
            publicClass.SaveTextFile(txtDateInWord2.Text, 6);
            publicClass.SaveTextFile(txtMoneyInWord1.Text, 8);
            publicClass.SaveTextFile(txtMoneyInWord2.Text, 9);
            publicClass.SaveTextFile(txtFor1.Text, 11);
            publicClass.SaveTextFile(txtFor2.Text, 12);
            publicClass.SaveTextFile(txtNationalCode1.Text, 14);
            publicClass.SaveTextFile(txtNationalCode2.Text, 15);
            publicClass.SaveTextFile(txtMoneyInNum1.Text, 17);
            publicClass.SaveTextFile(txtMoneyInNum2.Text, 18);
            publicClass.SaveTextFile(checkBox1.Checked.ToString(), 8);
            publicClass.SaveTextFile(checkBox2.Checked.ToString(), 18);

            MessageBox.Show("ذخیره شد", "Save");
        }

        private void Text_Setting_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Convert.ToBoolean(publicClass.File_Text[8]);
            checkBox2.Checked = Convert.ToBoolean(publicClass.File_Text[18]);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txtDateInWord1.Enabled = false;
                txtDateInWord2.Enabled = false;
                btnFont2.Enabled = false;
               
            }
            else
            {
                txtDateInWord1.Enabled = true;
                txtDateInWord2.Enabled = true;
                btnFont2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                txtNationalCode1.Enabled = false;
                txtNationalCode2.Enabled = false;
                btnFont5.Enabled = false;

            }
            else
            {
                txtNationalCode1.Enabled = true;
                txtNationalCode2.Enabled = true;
                btnFont5.Enabled = true;
            }
        }
    }
}
