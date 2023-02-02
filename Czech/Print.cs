using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Reflection;


public partial class Print : System.Windows.Forms.Form
{
    private System.ComponentModel.Container components;
    private System.Windows.Forms.Button printButton;
    private Font printFont;
    private TextBox txtHeitht;
    private TextBox txtWidth;
    private Label lblWidth;
    private Label lblHeight;
    private PrintDialog printDialog1;
    private PrintDocument printDocument1;
    private PrintPreviewDialog printPreviewDialog1;
    private StreamReader streamToPrint;
    

    public Print()
    {
        // The Windows Forms Designer requires the following call.
        InitializeComponent();
    }

    // The Click event is raised when the user clicks the Print button.
    private void printButton_Click(object sender, EventArgs e)
    {
        //try
        //{
        //    streamToPrint = new StreamReader
        //       ("C:\\Users\\Reza\\Documents\\New folder\\File.txt");
        //    try
        //    {
        //        printFont = new Font("Arial", 10);
        //        PrintDocument pd = new PrintDocument();
        //        pd.PrintPage += new PrintPageEventHandler
        //           (this.pd_PrintPage);
        //        pd.Print();
        //    }
        //    finally
        //    {
        //        streamToPrint.Close();
        //    }
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}

        try
        {
            PageSettings pageSettings = new PageSettings();
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            pageSettings.Landscape = false;
            //pageSettings.PaperSize.Width = Convert.ToInt32(txtWidth.Text);
            //pageSettings.PaperSize.Height = Convert.ToInt32(txtHeitht.Text);
            pageSettings.PaperSize.RawKind = 11;
            /* This assumes that a variable of type string, named filePath,
               has been set to the path of the file to print. */
            streamToPrint = new StreamReader("C:\\Users\\Reza\\Documents\\New folder\\File.txt");
            try
            {
                printFont = new Font("2  Titr", 10, FontStyle.Bold);
                PrintDocument pd = new PrintDocument();
                /* This assumes that a method, named pd_PrintPage, has been
                   defined. pd_PrintPage handles the PrintPage event. */
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                /* This assumes that a variable of type string, named 
                   printer, has been set to the printer's name. */
                pd.PrinterSettings.PrinterName = default;
                // Create a new instance of Margins with one inch margins.
                Margins margins = new Margins();
                pd.DefaultPageSettings.Margins = margins;


                pd.Print();
            }
            finally
            {
                streamToPrint.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred printing the file - " + ex.Message);
        }
    }

    // The PrintPage event is raised for each page to be printed.
    private void pd_PrintPage(object sender, PrintPageEventArgs ev)
    {
        float linesPerPage = 0;
        float yPos = 0;
        int count = 0;
        float leftMargin = ev.MarginBounds.Left;
        float topMargin = ev.MarginBounds.Top;
        string line = null;

        // Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height /
           printFont.GetHeight(ev.Graphics);

        // Print each line of the file.
        while (count < linesPerPage &&
           ((line = streamToPrint.ReadLine()) != null))
        {
            yPos = topMargin + (count *
               printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
               leftMargin, yPos, new StringFormat());
            count++;
        }

        // If more lines exist, print another page.
        if (line != null)
            ev.HasMorePages = true;
        else
            ev.HasMorePages = false;
    }

    // The Windows Forms Designer requires the following procedure.
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.printButton = new System.Windows.Forms.Button();
            this.txtHeitht = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.Location = new System.Drawing.Point(14, 58);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(308, 40);
            this.printButton.TabIndex = 0;
            this.printButton.Text = "Print the file.";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // txtHeitht
            // 
            this.txtHeitht.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtHeitht.Location = new System.Drawing.Point(167, 12);
            this.txtHeitht.Name = "txtHeitht";
            this.txtHeitht.Size = new System.Drawing.Size(100, 30);
            this.txtHeitht.TabIndex = 7;
            this.txtHeitht.Text = "11/693";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtWidth.Location = new System.Drawing.Point(14, 12);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(94, 30);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.Text = "8/268";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWidth.Location = new System.Drawing.Point(107, 9);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(62, 33);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = ": عرض";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHeight.Location = new System.Drawing.Point(265, 9);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(57, 33);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = ": طول";
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Print
            // 
            this.ClientSize = new System.Drawing.Size(337, 117);
            this.Controls.Add(this.txtHeitht);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.printButton);
            this.Name = "Print";
            this.Text = "Print Example";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}