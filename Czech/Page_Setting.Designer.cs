namespace Czech
{
    partial class Page_Setting
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
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtWidth.Location = new System.Drawing.Point(8, 9);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(94, 30);
            this.txtWidth.TabIndex = 6;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHeight.Location = new System.Drawing.Point(268, 6);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(57, 33);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = ": طول";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtHeight.Location = new System.Drawing.Point(172, 9);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(94, 30);
            this.txtHeight.TabIndex = 8;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWidth.Location = new System.Drawing.Point(104, 6);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(62, 33);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = ": عرض";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveToFile.Location = new System.Drawing.Point(57, 55);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToFile.TabIndex = 9;
            this.btnSaveToFile.Text = "ذخیره";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(245, 49);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(80, 35);
            this.btnBackward.TabIndex = 10;
            this.btnBackward.Text = "صفحه قبل";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // Page_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 90);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Page_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page_Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnBackward;
    }
}