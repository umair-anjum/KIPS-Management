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

namespace Kips_Managment.User_Control
{
    public partial class NewEmployee : UserControl
    {
        public NewEmployee()
        {
            InitializeComponent();
           
        }
        string imageLocation = "";
        DbConnection Connection = new DbConnection();
   //      string imageLocation = "";
       // private DbConnection Connection = new DbConnection();
        SqlConnection sql = new SqlConnection(@"Data Source=desktop-9g16don\sqlserver;Initial Catalog=kips;Integrated Security=True;");

        SqlCommand cmd;

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

            sql.Open();
            byte[] image = null;
            FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            image = reader.ReadBytes((int)stream.Length);
            string query = "insert into Faculty(TID,FullName,Cnic,Gender,Contact,Email,Address,Qualification,Classes,Subjects,Tphoto) values('" + Tidbox.Text + "','" + FName.Text + "','" + CNICTxt.Text + "','" + gender + "','" + PhoneNotxt.Text + "','" + EmailTxt.Text + "','" + AddressTxt.Text + "','" + QualificationCombobox.Text + "','" + ClassBox.Text + "','" + SubjectBox.Text + "',@image)"; 
            cmd = new SqlCommand(query, sql);
            cmd.Parameters.Add(new SqlParameter("@image", image));
            int num = cmd.ExecuteNonQuery();
            sql.Close();
            string Query = "insert into faculty(TID,FullName,Cnic,Gender,Contact,Email,Address,Qualification,Classes,Subjects,Tphoto) values('" + Tidbox.Text + "','" + FName.Text + "','" +CNICTxt.Text + "','" + gender + "','" + PhoneNotxt.Text + "','" + EmailTxt.Text + "','" + AddressTxt.Text + "','" + QualificationCombobox.Text + "','" + ClassBox.Text + "','"+ SubjectBox.Text+"','"+ pictureBox1.Image + "')";
            Console.WriteLine(Query);
            Connection.insert(Query);
            MessageBox.Show("Data saved Successfully....");


        }
    }
}
