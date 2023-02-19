using FarsiLibrary.Utils;
using FarsiLibrary.Win.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Czech
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FADatePicker fADatePicker = new FADatePicker();

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            fADatePicker.Text = $"{PersianDate.Now.Year}/{PersianDate.Now.Month}/{PersianDate.Now.Day}";
            fADatePicker.Location = new Point(16, 15);
            Font font = new Font("2  Titr", 10, FontStyle.Bold);
            fADatePicker.Font = font;
            Size size = new Size(159, 36);
            fADatePicker.Size = size;
            
            this.Controls.Add(fADatePicker);

        }
    }
}
