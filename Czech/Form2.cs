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
        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"X: {document.PrinterSettings.DefaultPageSettings.PrintableArea.X}, Y: {document.PrinterSettings.DefaultPageSettings.PrintableArea.Y}");

            
            //pPC.Zoom = 1;
            pPC.UseAntiAlias = true;

            document.DefaultPageSettings.Landscape = true;
            document.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;
            document.PrinterSettings.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;

            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            pPC.Document = document;
        
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                document.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;
                document.PrinterSettings.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;
                document.PrinterSettings.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;
                string text1 = "1 4 0 1 1 1 2 5";
                string text2 = "In document_PrintPage method. 2";
                string text3 = "2 5 0 0 0 0 0 0 0";
                Font printFont = new Font("Arial", 15, FontStyle.Regular);

                publicClass.Image_path = Directory.GetCurrentDirectory() + "\\Resources\\image2.jpg";
                publicClass.Czech_Image = Image.FromFile(publicClass.Image_path);

                int X = Convert.ToInt32(document.PrinterSettings.DefaultPageSettings.PrintableArea.X);
                int Y = Convert.ToInt32(document.PrinterSettings.DefaultPageSettings.PrintableArea.Y);
                
                
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
            //try
            //{
            //    document.PrinterSettings.PrinterName = "sdfsdxcvxckoki";
            //    document.Print();

            //}
            //catch(Exception ex)
            //{
            //   Exception exception = ex;
            //}
            //finally
            //{

            //}

            //MessageBox.Show($"{printDialog1.PrinterSettings.printer}");
            //printDialog1.PrinterSettings.DefaultPageSettings.Landscape = false;

            //DialogResult result = printDialog1.ShowDialog();

            //MessageBox.Show(printDialog1.PrinterSettings.PaperSizes.ToString());

            MessageBox.Show(document.DefaultPageSettings.PaperSize.Kind.ToString());

            //if (result == DialogResult.OK)
            //{
            //printPreviewDialog1.Document = document;
            //printPreviewDialog1.ShowDialog();

            document.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;
            document.PrinterSettings.PrinterName = default;
            document.Print();

            Form2_Load(null,null);

            MessageBox.Show(document.DefaultPageSettings.PaperSize.Kind.ToString());
            //}

        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
