using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace Czech
{
    public partial class Form2 : Form
    {

        string image_path = string.Empty;
        Image czech_image = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.Document = document;
            PrintDialog1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            MessageBox.Show($"width : {document.DefaultPageSettings.PaperSize.Width}" +
                $"\nhiegth: {document.DefaultPageSettings.PaperSize.Height}" +
                $"\nkind: {document.DefaultPageSettings.PaperSize.Kind}");

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
                string text = "In document_PrintPage method.\nIn document_PrintPage method. 2";
                Font printFont = new Font("Arial", 15, FontStyle.Regular);

                e.Graphics.DrawImage(czech_image, 0, 0);
                e.Graphics.DrawString(text, printFont, Brushes.Black, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred printing the file - " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            image_path = Directory.GetCurrentDirectory() + "\\Resources\\image2.jpg";
            czech_image = Image.FromFile(image_path);
            page_setting();
        }

        public void page_setting()
        {
            PageSettings pageSettings = new PageSettings();
            pageSettings.Landscape = true;
            PaperSize paperSize = new PaperSize();
            paperSize.RawKind = 11;

            document.DefaultPageSettings = pageSettings;
            document.DefaultPageSettings.PaperSize = paperSize;
        }

        public void page_value(string L1, string L2, string L3, string L4, string L4_2, string L5)
        {
            string text = "In document_PrintPage method.\nIn document_PrintPage method. 2";
            Font printFont = new Font("Arial", 35, FontStyle.Regular);
        }
    }
}
