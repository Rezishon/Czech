using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Czech
{
    public class PublicClass
    {
        #region Attributes

        static DateTime Val;
        public DateTime val 
        { 
            set { Val = value; }
            get { return Val; }
        }

        static string file_path = Directory.GetCurrentDirectory() + "\\Resources\\File.txt";
        static string[] file_text = new string[23];
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

        private static readonly List<string> ConvertedDigits = new List<string>();

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
            {"MoneyInNum_Font", 21},
            {"Date_Enable", 22}
        };
        
        static string For_;
        static string NationalCode_;
        static string Date_;
        static string Date_Word;
        static string Date_print;
        static string Money_;
        static string Money_Word;
        static string Money_print;

        static private string pageWidth_;
        static private string pageHeight_;
        
        static private string line1X_;
        static private string line1Y_;
        static public Font line1Font;
        public Font Line1font
        {
            set { line1Font = value; }
            get { return line1Font; }
        }



        static private string line2X_;
        static private string line2Y_;
        static private Font line2Font;
        public Font Line2font
        {
            set { line2Font = value; }
            get { return line2Font; }
        }

        static private string line3X_;
        static private string line3Y_;
        static private Font line3Font;
        public Font Line3font
        {
            set { line3Font = value; }
            get { return line3Font; }
        }


        static private string line4X_;
        static private string line4Y_;
        static private Font line4Font;
        public Font Line4font
        {
            set { line4Font = value; }
            get { return line4Font; }
        }


        static private string line5X_;
        static private string line5Y_;
        static private Font line5Font;
        public Font Line5font
        {
            set { line5Font = value; }
            get { return line5Font; }
        }


        static private string line6X_;
        static private string line6Y_;
        static private Font line6Font;
        public Font Line6font
        {
            set { line6Font = value; }
            get { return line6Font; }
        }


        static private string line7X_;
        static private string line7Y_;
        static private Font line7Font;

        static private Image Image;

        #endregion

        public PublicClass()
        {

        }

        //public void page_value(string L1, string L2, string L3, string L4, string L4_2, string L5)
        //{
        //    string text = "In document_PrintPage method.\nIn document_PrintPage method. 2";
        //    Font printFont = new Font("Arial", 35, FontStyle.Regular);
        //}

        public Dictionary<string, int> File_List
        {
            get { return File_lines_list; }
        }


        #region First Page Date

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
        public string Date 
        {
            set { Date_ = value; }
            get { return Date_; }
        }
        public string Date_word
        {
            set { Date_Word = value; }
            get { return Date_Word; }
        }
        public string Money
        {
            set 
            {
                Money_ = value; 
            }
            get { return Money_; }
        }
        public string Money_word
        {
            set { Money_Word = value; }
            get { return Money_Word; }
        }
        public string Money_Print 
        { 
            set { Money_print = value; }
            get { return Money_print; }
        }

        public string Date_Print 
        { 
            set { Date_print = value; }
            get { return Date_print; }
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

            pageLoad();
            document.DefaultPageSettings.PaperSize = new PaperSize("Custom", Convert.ToInt32(file_text[File_List["Length"]]), Convert.ToInt32(file_text[File_List["Width"]]));
            document.DefaultPageSettings.Landscape = false;

            document.PrintPage += new PrintPageEventHandler(document_PrintPage);

        }

        public void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Font[] fonts = { Line1font, Line2font, Line3font, Line4font, Line5font, Line6font };
                string[] strings = { Date_word, "DateInWord_X", "DateInWord_Y",
                    Date_Print,"DateInNum_X","DateInNum_Y", 
                    Money_word,"MoneyInWord_X","MoneyInWord_Y", 
                    For,"For_X","For_Y", 
                    NationalCode,"NationalCode_X","NationalCode_Y", 
                    Money_Print,"MoneyInNum_X","MoneyInNum_Y" };

                Image_path = Directory.GetCurrentDirectory() + "\\Resources\\image2.jpg";
                Czech_Image = Image.FromFile(Image_path);
                e.Graphics.DrawImage(Czech_Image, 0, 0);
                pageLoad();
                if (bool.Parse(File_Text[File_List["DateInWord_Enable"]]) == false) strings[0] = "";
                if (bool.Parse(File_Text[File_List["NationalCode_Enable"]]) == false) strings[12] = "";
                if (bool.Parse(File_Text[File_List["Date_Enable"]]) == false) strings[3] = Date;


                int j = 0;
                for (int i = 0; i < 18; i+=3)
                {
                    

                    e.Graphics.DrawString(strings[i], fonts[j], Brushes.Black, float.Parse(File_Text[File_List[strings[i+1]]]), float.Parse(File_Text[File_List[strings[i + 2]]]));
                    j++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred printing the file - " + ex.Message);
            }
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

        #region Convert


        #region Milimetr String To Inch String

        //MessageBox.Show(inch_To_100(string_To_Double("170")).ToString());

        public double string_To_Double(string str)
        {
            double inch = Convert.ToInt32(str) / 25.4;
            return inch;
        }
        public int inch_To_100(double D)
        {
            int Inch = Convert.ToInt32(D * 100);
            return Inch;
        }

        #endregion

        #region Inch String To Milimeter String 

        public double string_To_Double_X(string str)
        {
            double inch = Convert.ToInt32(str) * 25.4;
            return inch;
        }
        public int inch_To_100_X(double D)
        {
            int Inch = Convert.ToInt32(D / 100);
            return Inch;
        }


        #endregion

        #region Date to Word

        public void Date_To_Word(string str)
        {
            string[] strings = str.Split('/');
            var digit = long.Parse(strings[2]);
            Date_word = "";
            Date_word = ToAlphabet(digit);

            switch (int.Parse(strings[1]))
            {
                case 1:
                    Date_word += " فروردین ";
                    break;
                case 2:
                    Date_word += " اردیبهشت ";
                    break;
                case 3:
                    Date_word += " خرداد ";
                    break;
                case 4:
                    Date_word += " تیر ";
                    break;
                case 5:
                    Date_word += " مرداد ";
                    break;
                case 6:
                    Date_word += " شهریور ";
                    break;
                case 7:
                    Date_word += " مهر ";
                    break;
                case 8:
                    Date_word += " آبان ";
                    break;
                case 9:
                    Date_word += " آذر ";
                    break;
                case 10:
                    Date_word += " دی ";
                    break;
                case 11:
                    Date_word += " بهمن ";
                    break;
                case 12:
                    Date_word += " اسفند ";
                    break;
            }

            digit = long.Parse(strings[0]);
            Date_word += ToAlphabet(digit);
        }

        #endregion

        #region Date to Print

        public void C_PrintDate()
        {
            string[] strings = Date.Split('/');
            string str;
            foreach (string item in strings)
            {
                str = item;
                for (int i = 1; i < str.Length; i += 2)
                {
                    str = str.Insert(i, " ");
                }
                Date_Print += " " + str;
            }
            
        }


        #endregion

        #region Money To Word

        public bool InputValidator(string str)
        {
            if (str.Length > 12)
            {
                MessageBox.Show(@"مبلغ وارد شده باید حداکثر 12 رقم باشد");
                return false;
            }
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show(@"شما باید مبلغی وارد کنید");
                return false;
            }

            return true;
        }

        public string ToAlphabet(long digit)
        {
            ConvertedDigits.Clear();
            GetDigitName(digit);
            return string.Join(" ", ConvertedDigits.ToArray());
        }

        private static string GetDigitName(long digit)
        {
            var name = string.Empty;
            var digitAsString = digit.ToString();
            var digitLength = digitAsString.Length;
            var digitParts = new string[digitLength];
            var i = 0;

            foreach (var ch in digitAsString)
                digitParts[i++] = ch.ToString();

            #region if numberLength equal with 1

            if (digitLength == 1)
            {
                switch (digit)
                {
                    case 1:
                        name = "یک";
                        break;
                    case 2:
                        name = "دو";
                        break;
                    case 3:
                        name = "سه";
                        break;
                    case 4:
                        name = "چهار";
                        break;
                    case 5:
                        name = "پنج";
                        break;
                    case 6:
                        name = "شش";
                        break;
                    case 7:
                        name = "هفت";
                        break;
                    case 8:
                        name = "هشت";
                        break;
                    case 9:
                        name = "نه";
                        break;
                }
                // افزودن نام عدد به لیست
                ConvertedDigits.Add(name);
            }
            #endregion

            #region if numberLength equal with 2 and less then 20

            else if (digitLength == 2 && digit < 20)
            {
                switch (digit)
                {
                    case 10:
                        name = "ده";
                        break;
                    case 11:
                        name = "یازده";
                        break;
                    case 12:
                        name = "دوازده";
                        break;
                    case 13:
                        name = "سیزده";
                        break;
                    case 14:
                        name = "چهارده";
                        break;
                    case 15:
                        name = "پانزده";
                        break;
                    case 16:
                        name = "شانزده";
                        break;
                    case 17:
                        name = "هفده";
                        break;
                    case 18:
                        name = "هجده";
                        break;
                    case 19:
                        name = "نوزده";
                        break;
                }

                ConvertedDigits.Add(name);
            }

            #endregion

            #region if numberLength equal with 2 and more then 20

            else if (digitLength == 2 && digit >= 20)
            {
                // تبدیل عدد دو رقمی به دو قسمت. مثلا اگه 25 باشه پارت اول میشه 2 و پارت دو میشه 5
                var part1 = Convert.ToInt32(digitParts[0]);
                var part2 = Convert.ToInt32(digitParts[1]);

                if (part2 == 0)
                {
                    switch (part1)
                    {
                        case 2:
                            ConvertedDigits.Add("بیست");
                            break;
                        case 3:
                            ConvertedDigits.Add("سی");
                            break;
                        case 4:
                            ConvertedDigits.Add("چهل");
                            break;
                        case 5:
                            ConvertedDigits.Add("پنجاه");
                            break;
                        case 6:
                            ConvertedDigits.Add("شصت");
                            break;
                        case 7:
                            ConvertedDigits.Add("هفتاد");
                            break;
                        case 8:
                            ConvertedDigits.Add("هشتاد");
                            break;
                        case 9:
                            ConvertedDigits.Add("نود");
                            break;
                    }
                }
                else if (digit % 10L != 0L)
                {
                    name += GetDigitName(part1 * 10L) + "و";
                    // اضافه کردن نام عدد به لیست
                    ConvertedDigits.Add(name);
                    // فرخوانی دوباره متد GetDigitName با باقی مانده تقسیم عدد بر 10
                    GetDigitName(digit % 10L);
                }

            }

            #endregion

            #region if numberLength equal with 3

            else if (digitLength == 3)
            {
                // تبدیل عدد دو رقمی به سه قسمت. مثلا اگه 525 باشه پارت اول میشه 5 ، پارت دو میشه 2 و پارت سه میشه 5
                var part1 = Convert.ToInt32(digitParts[0]);
                var part2 = Convert.ToInt32(digitParts[1]);
                var part3 = Convert.ToInt32(digitParts[2]);

                if (part2 == 0 && part3 == 0)
                {
                    switch (part1)
                    {
                        case 1:
                            ConvertedDigits.Add("یکصد");
                            break;
                        case 2:
                            ConvertedDigits.Add("دویست");
                            break;
                        case 3:
                            ConvertedDigits.Add("سیصد");
                            break;
                        case 4:
                            ConvertedDigits.Add("چهارصد");
                            break;
                        case 5:
                            ConvertedDigits.Add("پانصد");
                            break;
                        case 6:
                            ConvertedDigits.Add("ششصد");
                            break;
                        case 7:
                            ConvertedDigits.Add("هفصد");
                            break;
                        case 8:
                            ConvertedDigits.Add("هشصد");
                            break;
                        case 9:
                            ConvertedDigits.Add("نهصد");
                            break;
                    }
                }
                else if (digit % 100L != 0L)
                {
                    name += GetDigitName(part1 * 100L) + "و";
                    ConvertedDigits.Add(name);

                    GetDigitName(digit % 100L);
                }
            }

            #endregion

            #region if numberLength more then 3

            else if (digitLength > 3)
            {
                switch (digitLength)
                {
                    case 4:
                    case 5:
                    case 6:
                        GetDigitName(digit / 1000L);
                        ConvertedDigits.Add("هزار");

                        if (digit % 1000L != 0)
                        {
                            ConvertedDigits.Add("و");
                            GetDigitName(digit % 1000L);
                        }
                        break;

                    case 7:
                    case 8:
                    case 9:
                        GetDigitName(digit / 1000000L);
                        ConvertedDigits.Add("میلیون");

                        if (digit % 1000000L != 0)
                        {
                            ConvertedDigits.Add("و");
                            GetDigitName(digit % 1000000L);
                        }
                        break;

                    case 10:
                    case 11:
                    case 12:
                        GetDigitName(digit / 1000000000L);
                        ConvertedDigits.Add("میلیارد");

                        if (digit % 1000000000L != 0)
                        {
                            ConvertedDigits.Add("و");
                            GetDigitName(digit % 1000000000L);
                        }
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                ConvertedDigits.Add(name);
            }

            #endregion

            return name;
        }

        #endregion

        #region Money To Print_Money

        public void C_PrintMoney()
        {
            string str = Money;
            for (int i = 1; i < str.Length; i += 2)
            {
                str = str.Insert(i, " ");
            }
            Money_Print = str;
        }


        #endregion



        #endregion

    }
}


