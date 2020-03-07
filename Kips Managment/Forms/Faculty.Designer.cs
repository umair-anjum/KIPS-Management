namespace Kips_Managment.Forms
{
    partial class Faculty
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
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.mark_test1 = new Kips_Managment.User_Control.faculty.Mark_test();
            this.update_Marks1 = new Kips_Managment.User_Control.faculty.Update_Marks();
            this.change_Password1 = new Kips_Managment.User_Control.Change_Password();
            this.markattendence1 = new Kips_Managment.User_Control.faculty.markattendence();
            this.attendence1 = new Kips_Managment.User_Control.faculty.Attendence();
            this.viewStudent1 = new Kips_Managment.User_Control.faculty.ViewStudent();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(106, 41);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "View Students";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(23, 119);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(106, 44);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Attendence";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(23, 178);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(106, 44);
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Final Marks";
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(23, 295);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(106, 44);
            this.metroTile4.TabIndex = 4;
            this.metroTile4.Text = "View Attendence";
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(23, 355);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(106, 41);
            this.metroTile5.TabIndex = 5;
            this.metroTile5.Text = "Change Password";
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(23, 411);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(106, 46);
            this.metroTile6.TabIndex = 6;
            this.metroTile6.Text = "Logout";
            this.metroTile6.UseSelectable = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(23, 238);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(106, 38);
            this.metroTile7.TabIndex = 13;
            this.metroTile7.Text = "Update Test Marks";
            this.metroTile7.UseSelectable = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // mark_test1
            // 
            this.mark_test1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mark_test1.Location = new System.Drawing.Point(162, 63);
            this.mark_test1.Name = "mark_test1";
            this.mark_test1.Size = new System.Drawing.Size(604, 379);
            this.mark_test1.TabIndex = 14;
            this.mark_test1.Load += new System.EventHandler(this.mark_test1_Load);
            // 
            // update_Marks1
            // 
            this.update_Marks1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_Marks1.Location = new System.Drawing.Point(162, 63);
            this.update_Marks1.Name = "update_Marks1";
            this.update_Marks1.Size = new System.Drawing.Size(603, 379);
            this.update_Marks1.TabIndex = 12;
            // 
            // change_Password1
            // 
            this.change_Password1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.change_Password1.Location = new System.Drawing.Point(162, 63);
            this.change_Password1.Margin = new System.Windows.Forms.Padding(2);
            this.change_Password1.Name = "change_Password1";
            this.change_Password1.Size = new System.Drawing.Size(604, 379);
            this.change_Password1.TabIndex = 11;
            // 
            // markattendence1
            // 
            this.markattendence1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.markattendence1.Location = new System.Drawing.Point(161, 63);
            this.markattendence1.Name = "markattendence1";
            this.markattendence1.Size = new System.Drawing.Size(604, 368);
            this.markattendence1.TabIndex = 10;
            // 
            // attendence1
            // 
            this.attendence1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.attendence1.Location = new System.Drawing.Point(161, 63);
            this.attendence1.Name = "attendence1";
            this.attendence1.Size = new System.Drawing.Size(553, 361);
            this.attendence1.TabIndex = 8;
            // 
            // viewStudent1
            // 
            this.viewStudent1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewStudent1.Location = new System.Drawing.Point(161, 63);
            this.viewStudent1.Name = "viewStudent1";
            this.viewStudent1.Size = new System.Drawing.Size(553, 361);
            this.viewStudent1.TabIndex = 7;
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 517);
            this.Controls.Add(this.mark_test1);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.update_Marks1);
            this.Controls.Add(this.change_Password1);
            this.Controls.Add(this.markattendence1);
            this.Controls.Add(this.attendence1);
            this.Controls.Add(this.viewStudent1);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Faculty";
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.Faculty_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private User_Control.faculty.ViewStudent viewStudent1;
        private User_Control.faculty.Attendence attendence1;
      //  private User_Control.faculty.viewmarks viewmarks1;
        private User_Control.faculty.markattendence markattendence1;
        private User_Control.Change_Password change_Password1;
        private User_Control.faculty.Update_Marks update_Marks1;
        private MetroFramework.Controls.MetroTile metroTile7;
        private User_Control.faculty.Mark_test mark_test1;
    }
}