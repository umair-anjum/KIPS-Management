namespace Kips_Managment.User_Control
{
    partial class EmployeeSalaryPayment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DOPPicker = new System.Windows.Forms.DateTimePicker();
            this.SalaryBOX = new System.Windows.Forms.TextBox();
            this.IDBOX = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary";
            // 
            // DOPPicker
            // 
            this.DOPPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOPPicker.Location = new System.Drawing.Point(175, 120);
            this.DOPPicker.Name = "DOPPicker";
            this.DOPPicker.Size = new System.Drawing.Size(200, 22);
            this.DOPPicker.TabIndex = 5;
            // 
            // SalaryBOX
            // 
            this.SalaryBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryBOX.Location = new System.Drawing.Point(175, 87);
            this.SalaryBOX.Name = "SalaryBOX";
            this.SalaryBOX.Size = new System.Drawing.Size(200, 22);
            this.SalaryBOX.TabIndex = 6;
            // 
            // IDBOX
            // 
            this.IDBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBOX.Location = new System.Drawing.Point(175, 44);
            this.IDBOX.Name = "IDBOX";
            this.IDBOX.Size = new System.Drawing.Size(200, 22);
            this.IDBOX.TabIndex = 8;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(175, 173);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 38);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(307, 173);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // EmployeeSalaryPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.IDBOX);
            this.Controls.Add(this.SalaryBOX);
            this.Controls.Add(this.DOPPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeSalaryPayment";
            this.Size = new System.Drawing.Size(574, 397);
            this.Load += new System.EventHandler(this.EmployeeSalaryPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DOPPicker;
        private System.Windows.Forms.TextBox SalaryBOX;
        private System.Windows.Forms.TextBox IDBOX;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnClose;
    }
}
