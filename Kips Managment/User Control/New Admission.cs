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


namespace Kips_Managment.User_Control
{
    public partial class New_Admission : UserControl
    {

        public MySqlConnection connection;
        
        public New_Admission()
        {
            InitializeComponent();
        }
        string imageLocation = "";
        private DbConnection Connection = new DbConnection();
        SqlConnection sql = new SqlConnection(@"Data Source=desktop-9g16don\sqlserver;Initial Catalog=kips;Integrated Security=True;");

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
            char gender = 'M';
            if (MaleRadio.Checked)
            {
                gender = 'M';
            }
            else if (FemaleRadio.Checked)
            {
                gender = 'F';
            }

            sql.Open();
            byte[] image = null;
            FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            image = reader.ReadBytes((int)stream.Length);
            string query = "insert into student (Sid,Fname,Lname,Password,Dob,Gender,Contact,City,Cnic,photo,FatherName,Address,DOA,Section,Class,TeacherID) values('" + RollNoBOX.Text + "','" + FnameBOX.Text + "','" + LNameBox.Text + "','" + PasswordBox.Text + "','" + DobDate.Text + "','" + gender + "','" + PhNOBox.Text + "','" + CityBox.Text + "','" + CNICBox.Text + "',@image,'" + FatherNameBOX.Text + "','" + AddressBox.Text + "','" + AddmissionDate.Text + "','" + SecBOX.Text + "','" + CLASSES.Text + "','T-002')";
            cmd = new SqlCommand(query, sql);
            cmd.Parameters.Add(new SqlParameter("@image", image));
            cmd.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show(" Data saved Successfully....");
            // string query = "insert into student(Sid,Fname,Lname,Password,DOB,Gender,Contact,City,Cnic,Photo,FatherName,Address,DOA,Section,Class) values('" + RollNoBOX.Text + "','" + FnameBOX.Text + "','" + LNameBox.Text + "','" + PasswordBox.Text + "','" + DobDate.Text + "','" + gender + "','" + PhNOBox.Text + "','" + CityBox.Text + "','" + CNICBox.Text + "','" + pictureBox1.Image + "','" + FatherNameBOX.Text + "','" + AddressBox.Text + "','" + AddmissionDate.Text + "','" + SecBOX.Text + "','" + CLASSES.Text + "')";
            string Query = "insert into student (Sid,Fname,Lname,Password,Dob,Gender,Contact,City,Cnic,photo,FatherName,Address,DOA,Section,Class,TeacherID) values('" + RollNoBOX.Text + "','" + FnameBOX.Text + "','" + LNameBox.Text + "','" + PasswordBox.Text + "','" + DobDate.Text + "','" + gender + "','" + PhNOBox.Text + "','" + CityBox.Text + "','" + CNICBox.Text + "','"+pictureBox1.Image+"','" + FatherNameBOX.Text + "','" + AddressBox.Text + "','" + AddmissionDate.Text + "','" + SecBOX.Text + "','" + CLASSES.Text + "','T-002')";
            Console.WriteLine(Query);
            Connection.insert(Query);
            
           

        }
    }
}
