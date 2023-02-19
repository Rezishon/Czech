namespace Czech
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPageSetting = new System.Windows.Forms.Button();
            this.btnTextSetting = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.document = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Czech.Properties.Resources.dsfsdf1;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(16, 15);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 43);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPageSetting
            // 
            this.btnPageSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPageSetting.BackgroundImage")));
            this.btnPageSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPageSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageSetting.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPageSetting.ForeColor = System.Drawing.Color.Black;
            this.btnPageSetting.Location = new System.Drawing.Point(131, 15);
            this.btnPageSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnPageSetting.Name = "btnPageSetting";
            this.btnPageSetting.Size = new System.Drawing.Size(123, 43);
            this.btnPageSetting.TabIndex = 1;
            this.btnPageSetting.Text = "تنظیمات صفحه";
            this.btnPageSetting.UseVisualStyleBackColor = true;
            this.btnPageSetting.Click += new System.EventHandler(this.btnPageSetting_Click);
            // 
            // btnTextSetting
            // 
            this.btnTextSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTextSetting.BackgroundImage")));
            this.btnTextSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTextSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextSetting.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTextSetting.ForeColor = System.Drawing.Color.Black;
            this.btnTextSetting.Location = new System.Drawing.Point(261, 15);
            this.btnTextSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnTextSetting.Name = "btnTextSetting";
            this.btnTextSetting.Size = new System.Drawing.Size(116, 43);
            this.btnTextSetting.TabIndex = 2;
            this.btnTextSetting.Text = "تنظیمات متن";
            this.btnTextSetting.UseVisualStyleBackColor = true;
            this.btnTextSetting.Click += new System.EventHandler(this.btnTextSetting_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackward.BackgroundImage")));
            this.btnBackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackward.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBackward.ForeColor = System.Drawing.Color.Black;
            this.btnBackward.Location = new System.Drawing.Point(385, 15);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(107, 43);
            this.btnBackward.TabIndex = 3;
            this.btnBackward.Text = "صفحه قبل";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.Document = this.document;
            this.PrintDialog1.UseEXDialog = true;
            // 
            // document
            // 
            this.document.DocumentName = "publicClass.document";
            this.document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage);
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Czech.Properties.Resources.dsfsdf2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 70);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnTextSetting);
            this.Controls.Add(this.btnPageSetting);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPageSetting;
        private System.Windows.Forms.Button btnTextSetting;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.PrintDialog PrintDialog1;
        private System.Drawing.Printing.PrintDocument document;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}