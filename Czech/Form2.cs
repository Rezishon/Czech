using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Czech
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        PrintDocument docToPrint = new PrintDocument();
        Image image = Image.FromFile("E:\\Czech\\Czech\\Resources\\image.jpg");

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {

            PrintDialog1.AllowSomePages = true;
            PrintDialog1.Document = document;

            DialogResult result = PrintDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                document.PrintPage += new PrintPageEventHandler(document_PrintPage);
                printPreviewDialog1.Document = document;
                printPreviewDialog1.ShowDialog();
                //document.Print();
            }
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                PageSettings pageSettings = new PageSettings();
                pageSettings.Landscape = true;
                PaperSize paperSize = new PaperSize("A5", 899, 444);
                paperSize.RawKind = 11;
                
                document.DefaultPageSettings = pageSettings;
                document.DefaultPageSettings.PaperSize = paperSize;

                string text = "In document_PrintPage method.";
                Font printFont = new Font("Arial", 35, FontStyle.Regular);

                e.Graphics.DrawString(text, printFont, Brushes.Black, 0, 0);
                e.Graphics.DrawImage(image, 0, 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred printing the file - " + ex.Message);
            }
            
            
        }
    }
}
