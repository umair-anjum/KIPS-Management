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
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using System.IO;

namespace Kips_Managment.User_Control
{
    public partial class VIew_Student : UserControl
    {
        public VIew_Student()
        {
            InitializeComponent();
        }
        DbConnection connection = new DbConnection();
        string imageLocation = "";
        //private DbConnection Connection = new DbConnection();
        SqlConnection sql = new SqlConnection(@"Data Source=desktop-9g16don\sqlserver;Initial Catalog=kips;Integrated Security=True;");

        SqlCommand cmd;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VIew_Student_Load(object sender, EventArgs e)
        {
            //DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            string query = "select Sid,Fname,Class from student";
            Console.WriteLine(query);
            dataTable = connection.select(query);
            //if (dataTa)
            //{
            //    MessageBox.Show("Table is Empty!!!");
            //}
            // else
            dataGridView1.DataSource = dataTable;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.Open();

            string query = "Select photo from student where Sid = '" + IDbpx.Text + "'";
            cmd = new SqlCommand(query, sql);
            SqlDataReader sqlData = cmd.ExecuteReader();
            sqlData.Read();
            if (sqlData.HasRows)
            {
               // textBox2.Text = sqlData[0].ToString();
                byte[] image = (byte[])sqlData[0];
                if (image == null)
                {
                   STD_PIC_BOX.Image = null;
                }
                else
                {
                    MemoryStream memory = new MemoryStream(image);
                    STD_PIC_BOX.Image = Image.FromStream(memory);
                }

            }

            else
            {
                MessageBox.Show("Pic is not Availaible!!");
            }
            sql.Close();
            DataSet dataSet = new DataSet();
            string Query = "select * from student where Sid = '"+IDbpx.Text+"'";
            dataSet =connection.select2(Query);


            foreach (DataRow r in dataSet.Tables[0].Rows)
            {

                this.RollNoBOX.Text = r["Sid"].ToString();
                this.AddmissionDate.Text = r["DOA"].ToString();
                this.FnameBOX.Text = r["Fname"].ToString();
                this.LNameBox.Text = r["Lname"].ToString();
                this.DobDate.Text = r["Dob"].ToString();
                this.Genderbox.Text = r["Gender"].ToString();
                this.PhNOBox.Text = r["Contact"].ToString();
                this.AddressBox.Text = r["Address"].ToString();
                this.CityBox.Text = r["City"].ToString();
                this.CnicBox.Text = r["Cnic"].ToString(); 
                this.SecBOX.Text = r["Section"].ToString();
                this.Classbox.Text = r["Class"].ToString();
                this.FatherNameBOX.Text = r["FatherName"].ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            string query = "select Sid,Fname,Class from student";
            Console.WriteLine(query);
            dataTable = connection.select(query);
            //if (dataTa)
            //{
            //    MessageBox.Show("Table is Empty!!!");
            //}
            // else
            dataGridView1.DataSource = dataTable;

        }
    }
}
