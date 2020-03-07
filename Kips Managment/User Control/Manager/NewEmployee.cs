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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using System.Speech.Synthesis;

namespace Kips_Managment.User_Control
{
    public partial class s : UserControl
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public s()
        {
            InitializeComponent();
           
        }
        string imageLocation = "";
        DbConnection Connection = new DbConnection();
   //      string imageLocation = "";
       // private DbConnection Connection = new DbConnection();
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");

        SqlCommand cmd,cmd1;

        private void NewEmployee_Load(object sender, EventArgs e)
        {
           
        }

        private void EmpSlct_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void facultySlct_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imageLocation = open.FileName.ToString();
                pictureBox1.ImageLocation = imageLocation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char gender = 'M';
            if (maleradio.Checked)
            {
                gender = 'M';
            }
            else if (femaleradio.Checked)
            {
                gender = 'F';
            }
            DataTable table = new DataTable();
            string quer = "select TID from faculty";
            Console.WriteLine(quer);

            table = Connection.select(quer);
            if (Tidbox.Text == "" || PasswordBOX.Text == "" || FName.Text == "" || CNICTxt.Text == "" || ClassBox.Text == "" || SubjectBox.Text == "" || PhoneNotxt.Text == "" || EmailTxt.Text == "" || AddressTxt.Text == "")
            {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                speechSynthesizer.Speak("Please fill the empty Information!");
                MessageBox.Show("Please fill the empty Information");
            }

          
        
          
           else if (table.Rows[0][0].ToString() == Tidbox.Text)
            {

                MessageBox.Show("the Faculty ID Already exists");
            }
            else
            {
                try
                {
                    sql.Open();
                    byte[] image = null;
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(stream);
                    image = reader.ReadBytes((int)stream.Length);
                    string query = "insert into Faculty(TID,FullName,Cnic,Gender,Contact,Email,Address,Qualification,Classes,Subjects,Tphoto,PASSWORD) values('" + Tidbox.Text + "','" + FName.Text + "','" + CNICTxt.Text + "','" + gender + "','" + PhoneNotxt.Text + "','" + EmailTxt.Text + "','" + AddressTxt.Text + "','" + QualificationCombobox.Text + "','" + ClassBox.Text + "','" + SubjectBox.Text + "',@image,'" + PasswordBOX.Text + "')";
                    string query1 = "insert into Login(Name,Password) values('" + Tidbox.Text + "','" + PasswordBOX.Text + "')";
                    cmd1= new SqlCommand(query1, sql);
                    cmd1.ExecuteNonQuery(); 
                    
                    cmd.Parameters.Add(new SqlParameter("@image", image));
                    int num = cmd.ExecuteNonQuery();
                    sql.Close();
                    string Query = "insert into faculty(TID,FullName,Cnic,Gender,Contact,Email,Address,Qualification,Classes,Subjects,Tphoto,PASSWORD) values('" + Tidbox.Text + "','" + FName.Text + "','" + CNICTxt.Text + "','" + gender + "','" + PhoneNotxt.Text + "','" + EmailTxt.Text + "','" + AddressTxt.Text + "','" + QualificationCombobox.Text + "','" + ClassBox.Text + "','" + SubjectBox.Text + "','" + pictureBox1.Image + "','" + PasswordBOX.Text + "')";
                    Console.WriteLine(Query);
                    Connection.insert(Query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                speechSynthesizer.Speak("Faculty added Successfully!");


                MessageBox.Show("Faculty added Successfully....");
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tidbox.Text = "";
            PasswordBOX.Text = "";
            FName.Text = "";
            CNICTxt.Text = "";
            ClassBox.Text = "";
            SubjectBox.Text = "";
            PhoneNotxt.Text = "";
            EmailTxt.Text = "";
            AddressTxt.Text = "";

        }
    }
}
