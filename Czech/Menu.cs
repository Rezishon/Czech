using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Czech
{
    public partial class Menu : Form
    {
        PublicClass publicClass = new PublicClass();

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            publicClass.pageLoad();
            publicClass.page_setting();
            this.document = publicClass.Document;
            
        }

        #region Page Buttons

        private void btnBackward_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void btnTextSetting_Click(object sender, EventArgs e)
        {
            Text_Setting text_Setting = new Text_Setting();
            text_Setting.Show();
            this.Close();
        }

        private void btnPageSetting_Click(object sender, EventArgs e)
        {
            Page_Setting page_setting = new Page_Setting();
            page_setting.Show();
            this.Close();
        }



        #endregion

        private void btnPrint_Click(System.Object sender, System.EventArgs e)
        {
            publicClass.page_setting();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.Document = document;
            //PrintDialog1.PrinterSettings.PrinterName = default;

            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printPreviewDialog1.Document = document;
               
                printPreviewDialog1.ShowDialog();
            }
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // lines 43, 44 | should change and replace in page_value()
                string text = "In document_PrintPage method.\nIn document_PrintPage method. 2\nIn document_PrintPage method. 3";
                Font printFont = new Font("Arial", 15, FontStyle.Regular);

                // Error
                e.Graphics.DrawImage(publicClass.Czech_Image, 0, 0);
                e.Graphics.DrawString(text, printFont, Brushes.Black, 540, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred printing the file - " + ex.Message);
            }
        }


        // Page Class:
        //public void page_setting()
        //{
        //    document.DefaultPageSettings.Landscape = true;
        //    document.DefaultPageSettings.PaperSize.RawKind = 11;
        //}
    }
}
