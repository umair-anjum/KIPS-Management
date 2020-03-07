using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using KipsManagment.MODEL;
using MySql.Data.MySqlClient;
using System.Speech.Synthesis;


namespace Kips_Managment.User_Control
{
    public partial class New_Admission : UserControl
    {

        public MySqlConnection connection;
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        public New_Admission()
        {
            InitializeComponent();
        }
        string imageLocation = "";
        private DbConnection Connection = new DbConnection();
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");

        SqlCommand cmd;

        private void New_Admission_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
            MainTimer.Enabled = true;
            char gender = 'M';
            if (MaleRadio.Checked)
            {
                gender = 'M';
            }
            else if (FemaleRadio.Checked)
            {
                gender = 'F';
            }
           
            DataTable table = new DataTable();
            string quer = "select Sid from student";
            Console.WriteLine(quer);
            table = Connection.select(quer);
            if (RollNoBOX.Text == ""
           || CLASSES.Text == ""
           || SecBOX.Text == ""
           || FnameBOX.Text == ""
           || LNameBox.Text == ""
           || FatherNameBOX.Text == ""
           || PhNOBox.Text == ""
           || PasswordBox.Text == ""
           || AddressBox.Text == ""
           || CityBox.Text == "")
            {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                speechSynthesizer.Speak("Please fill the empty Information!");
                MessageBox.Show("Please fill the empty Information");
            }

            else if (table.Rows[0][0].ToString() == RollNoBOX.Text)
            {

                MessageBox.Show("This Student ID Already exists");
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
                    string query = "insert into student (Sid,Fname,Lname,Password,Dob,Gender,Contact,City,Cnic,photo,FatherName,Address,DOA,Section,Class) values('" + RollNoBOX.Text + "','" + FnameBOX.Text + "','" + LNameBox.Text + "','" + PasswordBox.Text + "','" + DobDate.Value.Date + "','" + gender + "','" + PhNOBox.Text + "','" + CityBox.Text + "','" + CNICBox.Text + "',@image,'" + FatherNameBOX.Text + "','" + AddressBox.Text + "','" + AddmissionDate.Value.Date + "','" + SecBOX.Text + "','" + CLASSES.Text + "')";




                    cmd = new SqlCommand(query, sql);
                    cmd.Parameters.Add(new SqlParameter("@image", image));
                    cmd.ExecuteNonQuery();
                    sql.Close();

                    // string query = "insert into student(Sid,Fname,Lname,Password,DOB,Gender,Contact,City,Cnic,Photo,FatherName,Address,DOA,Section,Class) values('" + RollNoBOX.Text + "','" + FnameBOX.Text + "','" + LNameBox.Text + "','" + PasswordBox.Text + "','" + DobDate.Text + "','" + gender + "','" + PhNOBox.Text + "','" + CityBox.Text + "','" + CNICBox.Text + "','" + pictureBox1.Image + "','" + FatherNameBOX.Text + "','" + AddressBox.Text + "','" + AddmissionDate.Text + "','" + SecBOX.Text + "','" + CLASSES.Text + "')";


                    string Query = "insert into student (Sid,Fname,Lname,Password,Dob,Gender,Contact,City,Cnic,photo,FatherName,Address,DOA,Section,Class) values('" + RollNoBOX.Text + "','" + FnameBOX.Text + "','" + LNameBox.Text + "','" + PasswordBox.Text + "','" + DobDate.Text + "','" + gender + "','" + PhNOBox.Text + "','" + CityBox.Text + "','" + CNICBox.Text + "','" + pictureBox1.Image + "','" + FatherNameBOX.Text + "','" + AddressBox.Text + "','" + AddmissionDate.Text + "','" + SecBOX.Text + "','" + CLASSES.Text + "')";


                    Console.WriteLine(Query);
                    Connection.insert(Query);
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                speechSynthesizer.Speak("Student Inserted Successfully!");
            }
          /* if (Mainprogressbar.Value == 100)
            {
                MainTimer.Enabled = false;
                MessageBox.Show(" Student Inserted Successfully....");
            }*/
               
            }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            Mainprogressbar.Increment(10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RollNoBOX.Text = "";
            CLASSES.Text = "";
            SecBOX.Text = "";
            FnameBOX.Text = "";
            LNameBox.Text = "";
            FatherNameBOX.Text = "";
            PhNOBox.Text = "";
            PasswordBox.Text = "";
            AddressBox.Text = "";
            CityBox.Text = "";

        }

        private void Mainprogressbar_Click(object sender, EventArgs e)
        {

        }
    }

      /*  private void button3_Click(object sender, EventArgs e)
        {
          / RollNoBOX.Text = "";
            CLASSES.Text = "";
            SecBOX.Text = "";
            FnameBOX.Text = "";
            LNameBox.Text = "";
            FatherNameBOX.Text = "";
            PhNOBox.Text = "";
            PasswordBox.Text = "";
            AddressBox.Text = "";
            CityBox.Text = "";
            
        }*/

       /* private void MainTimer_Tick(object sender, EventArgs e)
        {
            Mainprogressbar.Increment(10);

        }*/
    }

