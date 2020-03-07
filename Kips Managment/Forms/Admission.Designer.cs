namespace Kips_Managment.Forms
{
    partial class Admission
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.update_Student1 = new Kips_Managment.User_Control.Update_Student();
            this.new_Admission1 = new Kips_Managment.User_Control.New_Admission();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(12, 73);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(115, 82);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "New Student";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(12, 180);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(115, 77);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Update Student";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(12, 285);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(115, 75);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Change Password";
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(12, 386);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(115, 78);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Exit";
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // update_Student1
            // 
            this.update_Student1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_Student1.Location = new System.Drawing.Point(169, 73);
            this.update_Student1.Name = "update_Student1";
            this.update_Student1.Size = new System.Drawing.Size(672, 391);
            this.update_Student1.TabIndex = 5;
            // 
            // new_Admission1
            // 
            this.new_Admission1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.new_Admission1.Location = new System.Drawing.Point(169, 73);
            this.new_Admission1.Name = "new_Admission1";
            this.new_Admission1.Size = new System.Drawing.Size(672, 391);
            this.new_Admission1.TabIndex = 4;
            // 
            // Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 499);
            this.Controls.Add(this.update_Student1);
            this.Controls.Add(this.new_Admission1);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "Admission";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admission_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private User_Control.New_Admission new_Admission1;
        private User_Control.Update_Student update_Student1;
    }
}