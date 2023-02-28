using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
            try
            {
                publicClass.pageLoad();
                //publicClass.page_setting();
                //this.document = publicClass.Document;


                //document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        #region Page Buttons

        private void btnBackward_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
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
            Text_Setting text_Setting = new Text_Setting();

            publicClass.pageLoad();
            //publicClass.page_setting();

            text_Setting.list = publicClass.File_List;
            text_Setting.text = publicClass.File_Text;


            PaperSize paperSize = new PaperSize();
            paperSize.RawKind = (int)PaperKind.A4;
            paperSize.Width = 826;
            paperSize.Height = 1169;


            document.DefaultPageSettings.Landscape = true;
            document.DefaultPageSettings.PaperSize = paperSize;
            document.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;

            //document.PrintPage -= new PrintPageEventHandler(publicClass.document_PrintPage);
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);

            publicClass.Line1font = text_Setting.Font_Load("DateInNum_Font");
            publicClass.Line2font = text_Setting.Font_Load("DateInWord_Font");
            publicClass.Line3font = text_Setting.Font_Load("MoneyInWord_Font");
            publicClass.Line4font = text_Setting.Font_Load("For_Font");
            publicClass.Line5font = text_Setting.Font_Load("NationalCode_Font");
            publicClass.Line6font = text_Setting.Font_Load("MoneyInNum_Font");




            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                publicClass.pageLoad();
                Font[] fonts = { publicClass.Line1font, publicClass.Line2font, publicClass.Line3font, publicClass.Line4font, publicClass.Line5font, publicClass.Line6font };
                string[] strings = { publicClass.Date_word, "DateInWord_X", "DateInWord_Y",
                    publicClass.Date_Print,"DateInNum_X","DateInNum_Y",
                    publicClass.Money_word,"MoneyInWord_X","MoneyInWord_Y",
                    publicClass.For,"For_X","For_Y",
                    publicClass.NationalCode,"NationalCode_X","NationalCode_Y",
                    publicClass.Money_Print,"MoneyInNum_X","MoneyInNum_Y" };

                int X = Convert.ToInt32(document.PrinterSettings.DefaultPageSettings.PrintableArea.X);
                int Y = Convert.ToInt32(document.PrinterSettings.DefaultPageSettings.PrintableArea.Y);
                float hei = (document.DefaultPageSettings.PaperSize.Width / 2);
                int H = int.Parse(publicClass.File_Text[publicClass.File_List["Length"]]);
                int W = int.Parse(publicClass.File_Text[publicClass.File_List["Width"]]);
                int PH = document.DefaultPageSettings.PaperSize.Height;


                publicClass.Image_path = "C:\\Users\\Public\\Documents\\BPT_Resources\\Image.jpg";
                publicClass.Czech_Image = Image.FromFile(publicClass.Image_path);

                //e.Graphics.DrawImage(publicClass.Czech_Image, PH - (H), (hei - (W / 2)) + Y);

                if (bool.Parse(publicClass.File_Text[publicClass.File_List["DateInWord_Enable"]]) == false) strings[0] = "";
                if (bool.Parse(publicClass.File_Text[publicClass.File_List["NationalCode_Enable"]]) == false) strings[12] = "";
                if (bool.Parse(publicClass.File_Text[publicClass.File_List["Date_Enable"]]) == false) strings[3] = publicClass.Date;


                int j = 0;
                for (int i = 0; i < 18; i += 3)
                {


                    e.Graphics.DrawString(strings[i], fonts[j], Brushes.Black, (PH - (H + X)) + float.Parse(publicClass.File_Text[publicClass.File_List[strings[i + 1]]]), ((hei - (W / 2)) - Y) + float.Parse(publicClass.File_Text[publicClass.File_List[strings[i + 2]]]));
                    j++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred printing the file - " + ex.Message);
            }


        }
    }
}
