using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Czech
{
    public partial class Text_Setting : Form
    {
        PublicClass publicClass = new PublicClass();
        Font font = null;
        string[] text;
        Dictionary<string, int> list;

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

        public void Font_set(string str)
        {
            fontDialog1.Font = Font_Load(str);
            fontDialog1.ShowDialog();
            font = fontDialog1.Font;
            //MessageBox.Show($"{font.Name},{font.Style},{font.Size}");
            publicClass.SaveTextFile($"{font.Name},{font.Size},{font.Style}", list[str]);
        }
        public Font Font_Load(string str)
        {
            Font fo;
            publicClass.pageLoad();
            string[] strings;
            strings = publicClass.File_Text[list[str]].Split(',');
            FontStyle style = new FontStyle();
            fo = new Font(strings[0], float.Parse(strings[1]), (FontStyle)Enum.Parse(typeof(FontStyle), strings[2]));
            //MessageBox.Show($"{font.Name},{font.Style},{font.Size}");
            //publicClass.SaveTextFile($"{font.Name},{font.Size},{font.Style}", list[str]);
            return fo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Saves

            publicClass.SaveTextFile(txtDateInNum1.Text, list["DateInNum_X"]);
            publicClass.SaveTextFile(txtDateInNum2.Text, list["DateInNum_Y"]);
            publicClass.SaveTextFile(txtDateInWord1.Text, list["DateInWord_X"]);
            publicClass.SaveTextFile(txtDateInWord2.Text, list["DateInWord_Y"]);
            publicClass.SaveTextFile(txtMoneyInWord1.Text, list["MoneyInWord_X"]);
            publicClass.SaveTextFile(txtMoneyInWord2.Text, list["MoneyInWord_Y"]);
            publicClass.SaveTextFile(txtFor1.Text, list["For_X"]);
            publicClass.SaveTextFile(txtFor2.Text, list["For_Y"]);
            publicClass.SaveTextFile(txtNationalCode1.Text, list["NationalCode_X"]);
            publicClass.SaveTextFile(txtNationalCode2.Text, list["NationalCode_Y"]);
            publicClass.SaveTextFile(txtMoneyInNum1.Text, list["MoneyInNum_X"]);
            publicClass.SaveTextFile(txtMoneyInNum2.Text, list["MoneyInNum_Y"]);

            publicClass.SaveTextFile(checkBox1.Checked.ToString(), list["DateInWord_Enable"]);
            publicClass.SaveTextFile(checkBox2.Checked.ToString(), list["NationalCode_Enable"]);

            #endregion

            #region Fonts

            

            #endregion

            MessageBox.Show("ذخیره شد", "Save");
        }

        private void Text_Setting_Load(object sender, EventArgs e)
        {
            text = publicClass.File_Text;
            list = publicClass.File_List;

            #region CheckBoxs

            checkBox1.Checked = Convert.ToBoolean(text[list["DateInWord_Enable"]]);
            checkBox2.Checked = Convert.ToBoolean(text[list["NationalCode_Enable"]]);

            #endregion

            #region TextBoxs


            txtDateInNum1.Text = text[list["DateInNum_X"]];
            txtDateInNum2.Text = text[list["DateInNum_Y"]];

            txtDateInWord1.Text = text[list["DateInWord_X"]];
            txtDateInWord2.Text = text[list["DateInWord_Y"]];

            txtMoneyInWord1.Text = text[list["MoneyInWord_X"]];
            txtMoneyInWord2.Text = text[list["MoneyInWord_Y"]];

            txtFor1.Text = text[list["For_X"]];
            txtFor2.Text = text[list["For_Y"]];

            txtNationalCode1.Text = text[list["NationalCode_X"]];
            txtNationalCode2.Text = text[list["NationalCode_Y"]];

            txtMoneyInNum1.Text = text[list["MoneyInNum_X"]];
            txtMoneyInNum2.Text = text[list["MoneyInNum_Y"]];

            #endregion

            #region Print Preview Control

            publicClass.page_setting();
            pPC.Document = publicClass.Document;
            pPC.UseAntiAlias = true;
            publicClass.Document.PrintPage += new PrintPageEventHandler(publicClass.document_PrintPage);



            #endregion

            #region Fonts

            publicClass.Line1font = Font_Load("DateInNum_Font");
            publicClass.Line2font = Font_Load("DateInWord_Font");
            publicClass.Line3font = Font_Load("MoneyInWord_Font");
            publicClass.Line4font = Font_Load("For_Font");
            publicClass.Line5font = Font_Load("NationalCode_Font");
            publicClass.Line6font = Font_Load("MoneyInNum_Font");

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

        private void btnFont1_Click(object sender, EventArgs e)
        {
            Font_set("DateInNum_Font");

            publicClass.Line1font = Font_Load("DateInNum_Font");
        }

        private void btnFont2_Click(object sender, EventArgs e)
        {
            Font_set("DateInWord_Font");
            publicClass.Line2font = Font_Load("DateInWord_Font");

        }

        private void btnFont3_Click(object sender, EventArgs e)
        {
            Font_set("MoneyInWord_Font");
            publicClass.Line3font = Font_Load("MoneyInWord_Font");

        }

        private void btnFont4_Click(object sender, EventArgs e)
        {
            Font_set("For_Font");
            publicClass.Line4font = Font_Load("For_Font");

        }

        private void btnFont5_Click(object sender, EventArgs e)
        {
            Font_set("NationalCode_Font");
            publicClass.Line5font = Font_Load("NationalCode_Font");

        }

        private void btnFont6_Click(object sender, EventArgs e)
        {
            Font_set("MoneyInNum_Font");
            publicClass.Line6font = Font_Load("MoneyInNum_Font");

        }
    }
}
