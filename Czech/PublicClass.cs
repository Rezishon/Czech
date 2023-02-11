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

        static string file_path = Directory.GetCurrentDirectory() + "\\Resources\\File.txt";
        static string[] file_text = new string[22];
        static public PrintDocument document = new PrintDocument();
        static public string image_path;
        static public Image czech_image;
        static PrintDialog PrintDialog1 = new PrintDialog();
        static PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();

        public PrintDocument Document 
        {
            set { document = value; }
            get { return document; }
        }
        public string Image_path 
        { 
            set { image_path = value; }
            get { return image_path;}
        }
        public Image Czech_Image 
        { 
            set { czech_image = value; }
            get { return czech_image;}
        }

        public static Dictionary<string, int> File_lines_list = new Dictionary<string, int>()
        {
            {"Length", 0},
            {"Width", 1},
            {"DateInNum_X", 2},
            {"DateInNum_Y", 3},
            {"DateInNum_Font", 4},
            {"DateInWord_X", 5},
            {"DateInWord_Y", 6},
            {"DateInWord_Font",7 },
            {"DateInWord_Enable", 8 },
            {"MoneyInWord_X", 9},
            {"MoneyInWord_Y", 10},
            {"MoneyInWord_Font", 11},
            {"For_X", 12},
            {"For_Y", 13},
            {"For_Font", 14},
            {"NationalCode_X", 15},
            {"NationalCode_Y", 16},
            {"NationalCode_Font", 17},
            {"NationalCode_Enable", 18},
            {"MoneyInNum_X", 19},
            {"MoneyInNum_Y", 20},
            {"MoneyInNum_Font", 21}
        };
        
        static string Date_;
        static string Money_;
        static string For_;
        static string NationalCode_;

        static private string pageWidth_;
        static private string pageHeight_;
        
        static private string line1X_;
        static private string line1Y_;
        static public Font line1Font;

        static private string line2X_;
        static private string line2Y_;
        static private Font line2Font;

        static private string line3X_;
        static private string line3Y_;
        static private Font line3Font;

        static private string line4X_;
        static private string line4Y_;
        static private Font line4Font;

        static private string line5X_;
        static private string line5Y_;
        static private Font line5Font;

        static private string line6X_;
        static private string line6Y_;
        static private Font line6Font;

        static private string line7X_;
        static private string line7Y_;
        static private Font line7Font;

        static private Image Image;

        #endregion

        public PublicClass()
        {

        }

        public void page_value(string L1, string L2, string L3, string L4, string L4_2, string L5)
        {
            string text = "In document_PrintPage method.\nIn document_PrintPage method. 2";
            Font printFont = new Font("Arial", 35, FontStyle.Regular);
        }

        public Dictionary<string, int> File_List
        {
            get { return File_lines_list; }
        }


        #region First Page Date

        public string Date 
        {
            set { Date_ = value; }
            get { return Date_; }
        }
        public string Money
        {
            set { Money_ = value; }
            get { return Money_; }
        }
        public string For
        {
            set { For_ = value; }
            get { return For_; }
        }
        public string NationalCode
        {
            set { NationalCode_ = value; }
            get { return NationalCode_; }
        }

        #endregion

        #region File Path && File Path

        public string File_Path 
        {
            set { file_path = value; }
            get { return file_path; }
        }
        public string[] File_Text 
        {
            set { file_text = value; }
            get { return file_text; }
        }

        #endregion

        #region Page

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
            File_Text = File.ReadAllLines(File_Path);
        }

        public void page_setting()
        {
            //document.DefaultPageSettings.Landscape = true;
            //document.DefaultPageSettings.PaperSize.RawKind = 0;
            //document.DefaultPageSettings.PaperSize.Width = Convert.ToInt32(PageWidth);
            //document.DefaultPageSettings.PaperSize.Height = Convert.ToInt32(PageHeight);
        }

        #endregion

        #region Document

        #endregion

        #region Text Settings

        #endregion

        #region Print *

        //public void btnPrint(System.Object sender, System.EventArgs e)
        //{
        //    PrintDialog1.AllowSomePages = true;
        //    PrintDialog1.Document = document;
        //    PrintDialog1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
        //    MessageBox.Show($"width : {document.DefaultPageSettings.PaperSize.Width}" +
        //        $"\nhiegth: {document.DefaultPageSettings.PaperSize.Height}" +
        //        $"\nkind: {document.DefaultPageSettings.PaperSize.Kind}");

        //    DialogResult result = PrintDialog1.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {
        //        printPreviewDialog1.Document = document;
        //        printPreviewDialog1.ShowDialog();
        //    }

        //}

        //private void document_PrintPage(PrintPageEventArgs e)
        //{
        //    try
        //    {
        //        // lines 43, 44 | should change and replace in page_value()
        //        string text = "In document_PrintPage method.\nIn document_PrintPage method. 2\nIn document_PrintPage method. 3";
        //        Font printFont = new Font("Arial", 15, FontStyle.Regular);

        //        // Error
        //        e.Graphics.DrawImage(czech_image, 0, 0);
        //        e.Graphics.DrawString(text, printFont, Brushes.Black, 540, 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred printing the file - " + ex.Message);
        //    }
        //}

        #endregion

        #region Save Data To File

        public void SaveTextFile(string str, int index)
        {
            File_Text[index] = str;
            try
            {
                File.WriteAllText(File_Path, "");
                foreach (string line in File_Text)
                {
                    File.AppendAllText(File_Path, line + Environment.NewLine);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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


