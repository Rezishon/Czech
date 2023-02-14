namespace Czech
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNmount = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtMount = new System.Windows.Forms.TextBox();
            this.txtFor = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.radioRial = new System.Windows.Forms.RadioButton();
            this.radioToman = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(171, 11);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 42);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = ": تاریخ";
            // 
            // lblNmount
            // 
            this.lblNmount.AutoSize = true;
            this.lblNmount.BackColor = System.Drawing.Color.Transparent;
            this.lblNmount.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNmount.Location = new System.Drawing.Point(445, 12);
            this.lblNmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmount.Name = "lblNmount";
            this.lblNmount.Size = new System.Drawing.Size(68, 42);
            this.lblNmount.TabIndex = 9;
            this.lblNmount.Text = ": مبلغ";
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.BackColor = System.Drawing.Color.Transparent;
            this.lblFor.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFor.Location = new System.Drawing.Point(417, 100);
            this.lblFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(91, 42);
            this.lblFor.TabIndex = 8;
            this.lblFor.Text = ": در وجه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(159, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = ": شماره ملی";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(16, 15);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.MinDate = new System.DateTime(1971, 3, 21, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker.Size = new System.Drawing.Size(159, 36);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2023, 2, 10, 0, 0, 0, 0);
            // 
            // txtMount
            // 
            this.txtMount.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMount.Location = new System.Drawing.Point(271, 15);
            this.txtMount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMount.Name = "txtMount";
            this.txtMount.Size = new System.Drawing.Size(177, 36);
            this.txtMount.TabIndex = 0;
            this.txtMount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // txtFor
            // 
            this.txtFor.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFor.Location = new System.Drawing.Point(16, 103);
            this.txtFor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFor.Name = "txtFor";
            this.txtFor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFor.Size = new System.Drawing.Size(405, 36);
            this.txtFor.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCode.Location = new System.Drawing.Point(16, 59);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(145, 36);
            this.txtCode.TabIndex = 2;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOk.BackgroundImage = global::Czech.Properties.Resources.dsfsdf2;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("2  Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(16, 148);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(497, 42);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "تایید";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // radioRial
            // 
            this.radioRial.AutoSize = true;
            this.radioRial.BackColor = System.Drawing.Color.Transparent;
            this.radioRial.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioRial.Location = new System.Drawing.Point(445, 78);
            this.radioRial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioRial.Name = "radioRial";
            this.radioRial.Size = new System.Drawing.Size(60, 34);
            this.radioRial.TabIndex = 7;
            this.radioRial.Text = "ریال";
            this.radioRial.UseVisualStyleBackColor = false;
            // 
            // radioToman
            // 
            this.radioToman.AutoSize = true;
            this.radioToman.BackColor = System.Drawing.Color.Transparent;
            this.radioToman.Checked = true;
            this.radioToman.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioToman.Location = new System.Drawing.Point(445, 52);
            this.radioToman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioToman.Name = "radioToman";
            this.radioToman.Size = new System.Drawing.Size(69, 34);
            this.radioToman.TabIndex = 6;
            this.radioToman.TabStop = true;
            this.radioToman.Text = "تومان";
            this.radioToman.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBox1.Location = new System.Drawing.Point(348, 63);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 34);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "تمام__";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = global::Czech.Properties.Resources.dsfsdf1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 201);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioToman);
            this.Controls.Add(this.radioRial);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtFor);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtMount);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.lblNmount);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNmount;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtMount;
        private System.Windows.Forms.TextBox txtFor;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton radioRial;
        private System.Windows.Forms.RadioButton radioToman;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

