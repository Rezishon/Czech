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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNmount = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMount = new System.Windows.Forms.TextBox();
            this.txtFor = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.Location = new System.Drawing.Point(252, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 33);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = ": تاریخ";
            // 
            // lblNmount
            // 
            this.lblNmount.AutoSize = true;
            this.lblNmount.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNmount.Location = new System.Drawing.Point(259, 57);
            this.lblNmount.Name = "lblNmount";
            this.lblNmount.Size = new System.Drawing.Size(54, 33);
            this.lblNmount.TabIndex = 1;
            this.lblNmount.Text = ": مبلغ";
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFor.Location = new System.Drawing.Point(239, 100);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(74, 33);
            this.lblFor.TabIndex = 1;
            this.lblFor.Text = ": در وجه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("2  Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(216, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = ": شماره ملی";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtMount
            // 
            this.txtMount.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMount.Location = new System.Drawing.Point(12, 57);
            this.txtMount.Name = "txtMount";
            this.txtMount.Size = new System.Drawing.Size(200, 30);
            this.txtMount.TabIndex = 4;
            this.txtMount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMount_KeyPress);
            // 
            // txtFor
            // 
            this.txtFor.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFor.Location = new System.Drawing.Point(12, 96);
            this.txtFor.Multiline = true;
            this.txtFor.Name = "txtFor";
            this.txtFor.Size = new System.Drawing.Size(200, 56);
            this.txtFor.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCode.Location = new System.Drawing.Point(12, 158);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 30);
            this.txtCode.TabIndex = 4;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("2  Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.Location = new System.Drawing.Point(12, 194);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(200, 34);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "تایید";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 340);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtFor);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtMount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.lblNmount);
            this.Controls.Add(this.lblDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNmount;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMount;
        private System.Windows.Forms.TextBox txtFor;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnOk;
    }
}

