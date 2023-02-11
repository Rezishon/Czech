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
            publicClass.page_setting();
            pPC.Zoom = 1;
            pPC.Document = publicClass.Document;

            pPC.UseAntiAlias = true;

            publicClass.Document.PrintPage += new PrintPageEventHandler(publicClass.document_PrintPage);
        }

        // No Use
        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                string text = "In document_PrintPage method.\nIn document_PrintPage method. 2\nIn document_PrintPage method. 3";
                Font printFont = new Font("Arial", 15, FontStyle.Regular);

                publicClass.Image_path = Directory.GetCurrentDirectory() + "\\Resources\\image2.jpg";
                publicClass.Czech_Image = Image.FromFile(publicClass.Image_path);

                e.Graphics.DrawImage(publicClass.Czech_Image, 0, 0);
                e.Graphics.DrawString(text, printFont, Brushes.Black, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred printing the file - " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(publicClass.inch_To_100_X(publicClass.string_To_Double_X("335")).ToString());
        }
    }
}
