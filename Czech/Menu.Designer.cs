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
            this.btnPageSetting.Location = new System.Drawing.Point(131, 15);
            this.btnPageSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnPageSetting.Name = "btnPageSetting";
            this.btnPageSetting.Size = new System.Drawing.Size(108, 43);
            this.btnPageSetting.TabIndex = 0;
            this.btnPageSetting.Text = "تنظیمات صفحه";
            this.btnPageSetting.UseVisualStyleBackColor = true;
            this.btnPageSetting.Click += new System.EventHandler(this.btnPageSetting_Click);
            // 
            // btnTextSetting
            // 
            this.btnTextSetting.Location = new System.Drawing.Point(247, 15);
            this.btnTextSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnTextSetting.Name = "btnTextSetting";
            this.btnTextSetting.Size = new System.Drawing.Size(116, 43);
            this.btnTextSetting.TabIndex = 0;
            this.btnTextSetting.Text = "تنظیمات متن";
            this.btnTextSetting.UseVisualStyleBackColor = true;
            this.btnTextSetting.Click += new System.EventHandler(this.btnTextSetting_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(371, 15);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(107, 43);
            this.btnBackward.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(494, 70);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnTextSetting);
            this.Controls.Add(this.btnPageSetting);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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