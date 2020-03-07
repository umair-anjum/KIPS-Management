using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KipsManagment.MODEL;

namespace Kips_Managment.User_Control.Admin
{
    public partial class ADD_Manager : UserControl
    { 

        DbConnection connection = new DbConnection();
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox MIDbox;
        private TextBox Addressbox;
        private TextBox CellNObox;
        private TextBox CNICBox;
        private TextBox QualifBOX;
        private TextBox PasswordBOx;
        private TextBox Fnamebox;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label9;

        public ADD_Manager()
        {
            InitializeComponent();
            PasswordBOx.Text = "";
            PasswordBOx.PasswordChar = '*';
            PasswordBOx.MaxLength = 25;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MIDbox = new System.Windows.Forms.TextBox();
            this.Addressbox = new System.Windows.Forms.TextBox();
            this.CellNObox = new System.Windows.Forms.TextBox();
            this.CNICBox = new System.Windows.Forms.TextBox();
            this.QualifBOX = new System.Windows.Forms.TextBox();
            this.PasswordBOx = new System.Windows.Forms.TextBox();
            this.Fnamebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone NO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "CNIC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Qualification";
            // 
            // MIDbox
            // 
            this.MIDbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIDbox.Location = new System.Drawing.Point(129, 32);
            this.MIDbox.Name = "MIDbox";
            this.MIDbox.Size = new System.Drawing.Size(100, 22);
            this.MIDbox.TabIndex = 9;
            // 
            // Addressbox
            // 
            this.Addressbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addressbox.Location = new System.Drawing.Point(445, 84);
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.Size = new System.Drawing.Size(100, 22);
            this.Addressbox.TabIndex = 10;
            // 
            // CellNObox
            // 
            this.CellNObox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellNObox.Location = new System.Drawing.Point(445, 47);
            this.CellNObox.Name = "CellNObox";
            this.CellNObox.Size = new System.Drawing.Size(100, 22);
            this.CellNObox.TabIndex = 11;
            // 
            // CNICBox
            // 
            this.CNICBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNICBox.Location = new System.Drawing.Point(129, 221);
            this.CNICBox.Name = "CNICBox";
            this.CNICBox.Size = new System.Drawing.Size(100, 22);
            this.CNICBox.TabIndex = 13;
            // 
            // QualifBOX
            // 
            this.QualifBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QualifBOX.Location = new System.Drawing.Point(129, 178);
            this.QualifBOX.Name = "QualifBOX";
            this.QualifBOX.Size = new System.Drawing.Size(100, 22);
            this.QualifBOX.TabIndex = 14;
            // 
            // PasswordBOx
            // 
            this.PasswordBOx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBOx.Location = new System.Drawing.Point(129, 106);
            this.PasswordBOx.Name = "PasswordBOx";
            this.PasswordBOx.Size = new System.Drawing.Size(100, 22);
            this.PasswordBOx.TabIndex = 15;
            // 
            // Fnamebox
            // 
            this.Fnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fnamebox.Location = new System.Drawing.Point(129, 66);
            this.Fnamebox.Name = "Fnamebox";
            this.Fnamebox.Size = new System.Drawing.Size(100, 22);
            this.Fnamebox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(465, 144);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(531, 144);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ADD_Manager
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fnamebox);
            this.Controls.Add(this.PasswordBOx);
            this.Controls.Add(this.QualifBOX);
            this.Controls.Add(this.CNICBox);
            this.Controls.Add(this.CellNObox);
            this.Controls.Add(this.Addressbox);
            this.Controls.Add(this.MIDbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADD_Manager";
            this.Size = new System.Drawing.Size(657, 405);
            this.Load += new System.EventHandler(this.ADD_Manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                char gender = 'M';
                if (radioButton1.Checked)
                {
                    gender = 'M';
                }
                else if (radioButton2.Checked)
                {
                    gender = 'F';
                }

                string query = "insert into manager(MID,FullName,Password,DOB,Qualification,CNIC,Address,Gender,PhoneNO) values('" + MIDbox.Text + "','" + Fnamebox.Text + "','" + PasswordBOx.Text + "','" + dateTimePicker1.Value.Date + "','" + QualifBOX.Text + "','" + CNICBox.Text + "','" + Addressbox.Text + "','" + gender + "','" + CellNObox.Text + "') ";
                Console.WriteLine(query);
                connection.insert(query);
                MessageBox.Show("Inserted sucessfully");
                MIDbox.Text = "";
                Fnamebox.Text = "";
                PasswordBOx.Text = "";
                QualifBOX.Text = "";
                CNICBox.Text = "";
                CellNObox.Text = "";
                Addressbox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ADD_Manager_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MIDbox.Text = "";
            Fnamebox.Text = "";
            PasswordBOx.Text = "";
            QualifBOX.Text = "";
            CNICBox.Text = "";
            CellNObox.Text = "";
            Addressbox.Text = "";

        }
    }
}
