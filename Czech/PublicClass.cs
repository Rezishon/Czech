using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Czech
{
    public class PublicClass
    {
        #region Attributes

        static private string pageWidth_;
        static private string pageHeight_;

        static private string line1X_;
        static private string line1Y_;
        static private string line1Font;

        static private string line2X_;
        static private string line2Y_;
        static private string line2Font;

        static private string line3X_;
        static private string line3Y_;
        static private string line3Font;

        static private string line4X_;
        static private string line4Y_;
        static private string line4Font;

        static private string line5X_;
        static private string line5Y_;
        static private string line5Font;

        static private string line6X_;
        static private string line6Y_;
        static private string line6Font;

        static private string line7X_;
        static private string line7Y_;
        static private string line7Font;

        static private Image Image;

        #endregion

        static string file_path = Directory.GetCurrentDirectory() + "\\Resources\\File.txt";
        static string[] file_text = new string[8];

        public PublicClass()
        {

        }

        public void page_value(string L1, string L2, string L3, string L4, string L4_2, string L5)
        {
            string text = "In document_PrintPage method.\nIn document_PrintPage method. 2";
            Font printFont = new Font("Arial", 35, FontStyle.Regular);
        }

        #region Page Settings

        public string PageWidth
        {
            set { pageWidth_ = value; }
            get { return pageWidth_; }
        }

        public string PageHeight
        {
            set { pageHeight_ = value; }
            get { return pageHeight_; }
        }

        public void pageLoad()
        {
            if (System.IO.File.Exists(file_path) == false)
            {
                System.IO.File.WriteAllText(file_path, "");

                file_text[0] = "899";
                file_text[1] = "444";

                SaveTextFile();
                pageLoad();
            }
            else
            {
                file_text = File.ReadAllLines(file_path);
            }
        }

        public void page_setting()
        {
            //PageSettings pageSettings = new PageSettings();
            //pageSettings.Landscape = true;
            //PaperSize paperSize = new PaperSize();
            //paperSize.RawKind = 11;

            //document.DefaultPageSettings = pageSettings;
            //document.DefaultPageSettings.PaperSize = paperSize;
        }

        #endregion

        #region Document

        #endregion

        #region Text Settings

        #endregion

        #region Print

        string image_path = string.Empty;
        Image czech_image = null;
        private void btnPrint(System.Object sender, System.EventArgs e)
        {
            //PrintDialog1.AllowSomePages = true;
            //PrintDialog1.Document = document;
            //PrintDialog1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            //MessageBox.Show($"width : {document.DefaultPageSettings.PaperSize.Width}" +
            //    $"\nhiegth: {document.DefaultPageSettings.PaperSize.Height}" +
            //    $"\nkind: {document.DefaultPageSettings.PaperSize.Kind}");

            //DialogResult result = PrintDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    printPreviewDialog1.Document = document;
            //    printPreviewDialog1.ShowDialog();
            //}
            //else
            //{

            //}
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // lines 43, 44 | should change and replace in page_value()
                string text = "In document_PrintPage method.\nIn document_PrintPage method. 2\nIn document_PrintPage method. 3";
                Font printFont = new Font("Arial", 15, FontStyle.Regular);

                // Error
                e.Graphics.DrawImage(czech_image, 0, 0);
                e.Graphics.DrawString(text, printFont, Brushes.Black, 540, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred printing the file - " + ex.Message);
            }
        }

        #endregion

        #region Save Data To File

        public void SaveTextFile()
        {
            File.WriteAllText(file_path, "");
            foreach (string line in file_text)
            {
                File.AppendAllText(file_path, line + Environment.NewLine);
            }
        }

        #endregion

        #region Save Date to Database

        #endregion

        #region Read Date From Database

        #endregion

        #region Text Box Settings

        public KeyPressEventArgs intOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            return e;
        }

        public KeyPressEventArgs doubleOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            return e;
        }

        #endregion

    }
}


