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
    public partial class Form2 : Form
    {
        PublicClass publicClass = new PublicClass();
        PaperSize paperSize = new PaperSize();
        public Form2()
        {
            InitializeComponent();
        }
        int X;
        int Y;
        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"X: {document.DefaultPageSettings.PrintableArea.X}, Y: {document.DefaultPageSettings.PrintableArea.Y}");


            
            paperSize.PaperName = "custom";
            paperSize.Width = 335;
            paperSize.Height = 669;

            pPC.Zoom = 1;
            pPC.Document = document;
            pPC.UseAntiAlias = true;

            document.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;
            document.PrinterSettings.DefaultPageSettings.Landscape = true;

            document.DefaultPageSettings.PaperSize = paperSize;
            document.DefaultPageSettings.Landscape = true;

            

            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                string text1 = "1 4 0 1 1 1 2 5";
                string text2 = "In document_PrintPage method. 2";
                string text3 = "2 5 0 0 0 0 0 0 0";
                Font printFont = new Font("Arial", 15, FontStyle.Regular);

                publicClass.Image_path = Directory.GetCurrentDirectory() + "\\Resources\\image2.jpg";
                publicClass.Czech_Image = Image.FromFile(publicClass.Image_path);

                int X = Convert.ToInt32(document.DefaultPageSettings.PrintableArea.X);
                int Y = Convert.ToInt32(document.DefaultPageSettings.PrintableArea.Y);

                e.Graphics.DrawImage(publicClass.Czech_Image, 0 - X, 0 - Y);
                e.Graphics.DrawString(text1, printFont, Brushes.Black, 10 - X, 10 - Y);
                e.Graphics.DrawString(text2, printFont, Brushes.Black, 10 - X, 50 - Y);
                e.Graphics.DrawString(text3, printFont, Brushes.Black, 10 - X, 90 - Y);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred printing the file - " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Text_Setting text_Setting = new Text_Setting();
            //text_Setting.Text_Setting_Load(sender, e);

            //printDialog1.Document = document;
            //printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;
            //printDialog1.PrinterSettings.DefaultPageSettings.Landscape = true;

            //MessageBox.Show($"{printDialog1.PrinterSettings.printer}");

            //DialogResult result = printDialog1.ShowDialog();

            //MessageBox.Show(printDialog1.PrinterSettings.PaperSizes.ToString());

            //if (result == DialogResult.OK)
            //{
            // print instently:
            try
            {
                document.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("A5",826,582);
                document.Print();
            }
            finally
            {
                Form2_Load(null,null);
            }
            //printPreviewDialog1.Document = document;
            //printPreviewDialog1.ShowDialog();
            //}
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
