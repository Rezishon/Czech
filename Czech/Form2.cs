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
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                pPC.Zoom = 1;
                PaperSize paperSize = new PaperSize();
                paperSize.RawKind = (int)PaperKind.A4;
                paperSize.Width = 826;
                paperSize.Height = 1169;





                pPC.UseAntiAlias = true;

                document.DefaultPageSettings.Landscape = true;
                document.DefaultPageSettings.PaperSize = paperSize;
                document.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;
                //document.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;
                //document.PrinterSettings.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;

                document.PrintPage += new PrintPageEventHandler(document_PrintPage);
                pPC.Document = document;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                int X = Convert.ToInt32(document.PrinterSettings.DefaultPageSettings.PrintableArea.X);
                int Y = Convert.ToInt32(document.PrinterSettings.DefaultPageSettings.PrintableArea.Y);
                int H = int.Parse(publicClass.File_Text[publicClass.File_List["Length"]]);
                int W = int.Parse(publicClass.File_Text[publicClass.File_List["Width"]]);
                int PH = document.DefaultPageSettings.PaperSize.Height;


                float hei = (document.DefaultPageSettings.PaperSize.Width / 2) ;


                e.Graphics.DrawImage(publicClass.Czech_Image, document.DefaultPageSettings.PaperSize.Height - (H + X), (hei -(335/2)) - Y);
                //e.Graphics.DrawString(text1, printFont, Brushes.Black, PH - (H + X) + float.Parse(publicClass.File_Text[publicClass.File_List[strings[i + 1]]]), (hei - (W / 2)) - Y + float.Parse(publicClass.File_Text[publicClass.File_List[strings[i + 2]]])));
                e.Graphics.DrawString(text2, printFont, Brushes.Black, document.DefaultPageSettings.PaperSize.Height - (H + X) + 10, (hei - (335 / 2)) - Y + 50);
                e.Graphics.DrawString(text3, printFont, Brushes.Black, document.DefaultPageSettings.PaperSize.Height - (H + X) + 10, (hei - (335 / 2)) - Y + 90);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred printing the file - " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PaperSize paperSize = new PaperSize();
            //paperSize.RawKind = (int)PaperKind.A5;
            //paperSize.Width = 335;
            //paperSize.Height = 669;

            //printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;
            DialogResult result = printDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {
                document.Print();
            }
        }
    }
}
