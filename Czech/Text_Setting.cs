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
        Font font = null;

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
            Font_set("DateInNum_Font");
        }

        public void Font_set(string str)
        {
            fontDialog1.ShowDialog();
            font = fontDialog1.Font;
            MessageBox.Show($"{font.Name},{font.Style},{font.Size}");
            //publicClass.SaveTextFile($"{font.Name},{font.Style},{font.Size}", publicClass.File_List[str]);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Saves

            publicClass.SaveTextFile(txtDateInNum1.Text, publicClass.File_List["DateInNum_X"]);
            publicClass.SaveTextFile(txtDateInNum2.Text, publicClass.File_List["DateInNum_Y"]);
            publicClass.SaveTextFile(txtDateInWord1.Text, publicClass.File_List["DateInWord_X"]);
            publicClass.SaveTextFile(txtDateInWord2.Text, publicClass.File_List["DateInWord_Y"]);
            publicClass.SaveTextFile(txtMoneyInWord1.Text, publicClass.File_List["MoneyInWord_X"]);
            publicClass.SaveTextFile(txtMoneyInWord2.Text, publicClass.File_List["MoneyInWord_Y"]);
            publicClass.SaveTextFile(txtFor1.Text, publicClass.File_List["For_X"]);
            publicClass.SaveTextFile(txtFor2.Text, publicClass.File_List["For_Y"]);
            publicClass.SaveTextFile(txtNationalCode1.Text, publicClass.File_List["NationalCode_X"]);
            publicClass.SaveTextFile(txtNationalCode2.Text, publicClass.File_List["NationalCode_Y"]);
            publicClass.SaveTextFile(txtMoneyInNum1.Text, publicClass.File_List["MoneyInNum_X"]);
            publicClass.SaveTextFile(txtMoneyInNum2.Text, publicClass.File_List["MoneyInNum_Y"]);
            publicClass.SaveTextFile(checkBox1.Checked.ToString(), publicClass.File_List["DateInWord_Enable"]);
            publicClass.SaveTextFile(checkBox2.Checked.ToString(), publicClass.File_List["NationalCode_Enable"]);

            #endregion

            #region Fonts

            

            #endregion

            MessageBox.Show("ذخیره شد", "Save");
        }

        private void Text_Setting_Load(object sender, EventArgs e)
        { // کند
            #region CheckBoxs

            checkBox1.Checked = Convert.ToBoolean(publicClass.File_Text[publicClass.File_List["DateInWord_Enable"]]);
            checkBox2.Checked = Convert.ToBoolean(publicClass.File_Text[publicClass.File_List["NationalCode_Enable"]]);

            #endregion

            #region TextBoxs

            txtDateInNum1.Text = publicClass.File_Text[publicClass.File_List["DateInNum_X"]];
            txtDateInNum2.Text = publicClass.File_Text[publicClass.File_List["DateInNum_Y"]];

            txtDateInWord1.Text = publicClass.File_Text[publicClass.File_List["DateInWord_X"]];
            txtDateInWord2.Text = publicClass.File_Text[publicClass.File_List["DateInWord_Y"]];

            txtMoneyInWord1.Text = publicClass.File_Text[publicClass.File_List["MoneyInWord_X"]];
            txtMoneyInWord2.Text = publicClass.File_Text[publicClass.File_List["MoneyInWord_Y"]];

            txtFor1.Text = publicClass.File_Text[publicClass.File_List["For_X"]];
            txtFor2.Text = publicClass.File_Text[publicClass.File_List["For_Y"]];

            txtNationalCode1.Text = publicClass.File_Text[publicClass.File_List["NationalCode_X"]];
            txtNationalCode2.Text = publicClass.File_Text[publicClass.File_List["NationalCode_Y"]];

            txtMoneyInNum1.Text = publicClass.File_Text[publicClass.File_List["MoneyInNum_X"]];
            txtMoneyInNum2.Text = publicClass.File_Text[publicClass.File_List["MoneyInNum_Y"]];

            #endregion

            #region Print Preview Control

            pPC.Document = publicClass.Document;

            #endregion

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
