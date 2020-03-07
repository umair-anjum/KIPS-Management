using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using KipsManagment.MODEL;

namespace Kips_Managment.User_Control
{
    public partial class ViewFaculty : UserControl
    {
        public ViewFaculty()
        {
            InitializeComponent();
        }
        string imageLocation = "";
        DbConnection connection = new DbConnection();
        //      string imageLocation = "";
        // private DbConnection Connection = new DbConnection();
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");

        SqlCommand cmd;
        private void button2_Click(object sender, EventArgs e)
        {
            //DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            string query = "select TID,FullName,Qualification from faculty";
            Console.WriteLine(query);
            dataTable = connection.select(query);
            //if (dataTa)
            //{
            //    MessageBox.Show("Table is Empty!!!");
            //}
            // else
            dataGridView1.DataSource = dataTable;
        }

        private void ViewFaculty_Load(object sender, EventArgs e)
        {
            //DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            string query = "select TID,FullName,Qualification from faculty";
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

            string query = "select Tphoto from faculty where TID = '" + TidBOx.Text + "'";
            cmd = new SqlCommand(query, sql);
            SqlDataReader sqlData = cmd.ExecuteReader();
            sqlData.Read();
            if (sqlData.HasRows)
            {
                // textBox2.Text = sqlData[0].ToString();
                byte[] image = (byte[])sqlData[0];
                if (image == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream memory = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(memory);
                }

            }

            else
            {
                MessageBox.Show("Pic is not Availaible!!");
            }
            sql.Close();
            DataSet dataSet = new DataSet();
            string Query = "select * from faculty where TID = '" + TidBOx.Text + "'";
            dataSet = connection.select2(Query);


            foreach (DataRow r in dataSet.Tables[0].Rows)
            {

                this.FacIDbox.Text = r["TID"].ToString();
                this.FName.Text = r["FullName"].ToString();
                this.CNICTxt.Text = r["Cnic"].ToString();
                this.GenderBox.Text = r["Gender"].ToString();
                this.PhoneNotxt.Text = r["Contact"].ToString();
                this.EmailTxt.Text = r["Email"].ToString();
                this.AddressTxt.Text = r["Address"].ToString();
                this.qbox.Text = r["Qualification"].ToString();
                this.Classesbox.Text = r["Classes"].ToString();
                this.sbox.Text = r["Subjects"].ToString();
                this.tphoto.Text = r["Tphoto"].ToString();
            }
        }

        private void subjBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
