using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kips_Managment.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;
using Kips_Managment.User_Control;

namespace Kips_Managment
{
    public partial class LogIn : MetroFramework.Forms.MetroForm
    {
        // private Login objLogin = new Login();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public static string txt;
        //   private LogIn objLogin = new LogIn();

        public LogIn()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            LoginPass.Text = "";
            LoginPass.PasswordChar = '*';
            LoginPass.MaxLength = 25;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroComboBox2.SelectedIndex = 0;
            metroComboBox1.SelectedIndex = 0;

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedIndex) {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
                case 1:


                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;

            }
        }

        private void MetroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //   Student obj = new Student();
            //   obj.Show();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt = LoginID.Text;
            //  Change_Password change = new Change_Password(txt);
            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True; ");
            sql.Open();
            string query = "Select Name,Password From Login Where Name = '" + LoginID.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            //adapter.SelectCommand.ExecuteNonQuery();
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows[0][0].ToString() == LoginID.Text && table.Rows[0][1].ToString() == LoginPass.Text)
            {
                if (loginSelect.Text == "Manager" )
                {
                    Manager dashBoard = new Manager();
                    this.Hide();
                    dashBoard.Show();
                    dashBoard.StyleManager = this.StyleManager;
                }
                else if (loginSelect.Text == "Faculty" )
                {
                    Faculty faculty = new Faculty();
                    this.Hide();
                    faculty.Show();
                    faculty.StyleManager = this.StyleManager;

                }
                else if (loginSelect.Text == "Accountant" && LoginID.Text=="Accountant")
                {
                    Accountant accountant = new Accountant();
                    this.Hide();
                    accountant.Show();
                    accountant.StyleManager = this.StyleManager;


                }
                else if (loginSelect.Text == "Admin"&& LoginID.Text=="Admin" )
                {
                    Admin ad = new Admin();
                    this.Hide();
                    ad.Show();
                    ad.StyleManager = this.StyleManager;


                }
                else
                {

                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                    speechSynthesizer.Speak("Select Your Own Account!!!");
                }
            }
            else
            {
                if (table.Rows[0][0].ToString() == LoginID.Text && table.Rows[0][1].ToString() != LoginPass.Text)
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                    speechSynthesizer.Speak("Enter Correct Password!");
                    MessageBox.Show("Please Enter Correct  Password");
                }
                else if(table.Rows[0][0].ToString() != LoginID.Text && table.Rows[0][1].ToString() == LoginPass.Text)
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                    speechSynthesizer.Speak("Enter Correct username!");
                    MessageBox.Show("Please Enter Correct User Name ");
                }
                else if (table.Rows[0][0].ToString() != LoginID.Text && table.Rows[0][1].ToString() != LoginPass.Text)
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                    speechSynthesizer.Speak("Enter Correct username and password!");
                    MessageBox.Show("Please Enter Correct Username and password ");
                }
            }
            }

        public void fun()
        {

        }

            private void LoginSelect_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void LoginID_Click(object sender, EventArgs e)
            {

            }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            loginSelect.Text = "Manager";
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            loginSelect.Text = "Accountant";
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            loginSelect.Text = "Faculty";
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            loginSelect.Text = "Admin";
        }
    }
    }


