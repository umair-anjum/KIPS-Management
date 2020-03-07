namespace Speak.StartingControls
{
    partial class Manager
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
            this.Mname = new System.Windows.Forms.TextBox();
            this.Mpass = new System.Windows.Forms.TextBox();
            this.btnlog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mname
            // 
            this.Mname.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname.ForeColor = System.Drawing.Color.Black;
            this.Mname.Location = new System.Drawing.Point(513, 109);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(215, 27);
            this.Mname.TabIndex = 1;
            this.Mname.TextChanged += new System.EventHandler(this.Mname_TextChanged);
            // 
            // Mpass
            // 
            this.Mpass.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mpass.ForeColor = System.Drawing.Color.Black;
            this.Mpass.Location = new System.Drawing.Point(513, 162);
            this.Mpass.Name = "Mpass";
            this.Mpass.Size = new System.Drawing.Size(215, 27);
            this.Mpass.TabIndex = 1;
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlog.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.Location = new System.Drawing.Point(598, 227);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(130, 48);
            this.btnlog.TabIndex = 2;
            this.btnlog.Text = "Login";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 71);
            this.panel2.TabIndex = 5;
            // 
            // btncan
            // 
            this.btncan.BackColor = System.Drawing.Color.Gray;
            this.btncan.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.Location = new System.Drawing.Point(433, 227);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(130, 48);
            this.btncan.TabIndex = 2;
            this.btncan.Text = "Cancel";
            this.btncan.UseVisualStyleBackColor = false;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncan);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.Mpass);
            this.Controls.Add(this.Mname);
            this.Name = "Manager";
            this.Size = new System.Drawing.Size(1126, 622);
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.TextBox Mpass;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncan;
    }
}
