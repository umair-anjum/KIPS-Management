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
    public partial class UpdateStudent : UserControl
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }
        DbConnection connection = new DbConnection();
       // string imageLocation = "";
        //private DbConnection Connection = new DbConnection();
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");

       // SqlCommand cmd;

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                string query = "select Sid,Fname,Class from student";
                Console.WriteLine(query);
                dataTable = connection.select(query);
                dataGridView1.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                string query = "select Sid,Fname,Class from student";
                Console.WriteLine(query);
                dataTable = connection.select(query);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string Query = "select * from student where Sid = '" + Regbox.Text + "'";
            dataSet = connection.select2(Query);


            foreach (DataRow r in dataSet.Tables[0].Rows)
            {

                //this..Text = r["Sid"].ToString();
                //this.AddmissionDate.Text = r["DOA"].ToString();
                this.FNameU.Text = r["Fname"].ToString();
                //this.L.Text = r["Lname"].ToString();
                //this.DobDate.Text = r["Dob"].ToString();
                //this.Genderbox.Text = r["Gender"].ToString();
                this.CellNoU.Text = r["Contact"].ToString();
                this.AddressU.Text = r["Address"].ToString();
                this.Citybox.Text = r["City"].ToString();
               // this.CnicBox.Text = r["Cnic"].ToString();
                this.sectionbox.Text = r["Section"].ToString();
                this.Classbox.Text = r["Class"].ToString();
                //this.FatherNameBOX.Text = r["FatherName"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if(deleteradio.Checked == true)
            {
                sql.Open();
                try
                {
                    string query = "delete from student where Sid = '" + Regbox.Text + "'";

                    Console.WriteLine(query);
                    connection.delete(query);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
                    adapter.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!!");
                    sql.Close();
                    Regbox.Text = "";
                    FNameU.Text = "";
                    sectionbox.Text = "";
                    CellNoU.Text = "";
                    Citybox.Text = "";
                    AddressU.Text = "";
                    Classbox.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(updateradio.Checked == true)
            {
               
                try
                {
                    sql.Open();
                    string query = "update student set Fname = '"+ FNameU.Text + "'," +
                        " Section = '"+ sectionbox.Text + "', Contact = '"+CellNoU.Text+"'," +
                        "City = '"+Citybox.Text+"', Address = '"+AddressU.Text+"'," +
                        "Class = '"+Classbox.Text+"' where Sid ='"+Regbox.Text+"'";
                    Console.WriteLine(query);
                    connection.update(query); 
                    SqlDataAdapter sqlData = new SqlDataAdapter(query, sql);
                    sqlData.SelectCommand.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("DATA UPDATED SUCCESSFULY");
                    Regbox.Text = "";
                    FNameU.Text = "";
                    sectionbox.Text = "";
                    CellNoU.Text = "";
                    Citybox.Text = "";
                    AddressU.Text = "";
                    Classbox.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regbox.Text = "";
            FNameU.Text = "";
            sectionbox.Text = "";
            CellNoU.Text = "";
            Citybox.Text = "";
            AddressU.Text = "";
            Classbox.Text = "";

        }
    }
}
