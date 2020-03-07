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
using KipsManagment.MODEL;
namespace Kips_Managment.User_Control
{
    public partial class UpdateFaculty : UserControl
    {
        DbConnection connection = new DbConnection();
        public UpdateFaculty()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");
        private void UpdateFaculty_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                string query = "select TID,FullName,Classes from faculty";
                Console.WriteLine(query);
                dataTable = connection.select(query);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Deleteradio.Checked == true)
            {
                sql.Open();
                try
                {
                    string query = "delete from faculty where TID = '" + regIDBox.Text + "'";

                    Console.WriteLine(query);
                    connection.delete(query);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
                    adapter.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!!");
                    sql.Close();
                    regIDBox.Text = "";
                    FNameU.Text = "";
                    CellNoU.Text = "";
                    QualificationBOX.Text = "";
                    AddressU.Text = "";
                    SubjectBOX.Text = "";
                    ClassBox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (UpdateRadio.Checked == true)
            {

                try
                {
                    sql.Open();
                    string query = "update faculty set FullName = '" + FNameU.Text + "', Contact = '" + CellNoU.Text + "'," +
                        "Address = '" + AddressU.Text + "', Qualification = '" + QualificationBOX.Text+ "'," +
                        "Classes = '" + ClassBox.Text +"', Subjects = '" + SubjectBOX.Text + "' where TID ='" + regIDBox.Text + "'";
                    Console.WriteLine(query);
                    connection.update(query);
                    SqlDataAdapter sqlData = new SqlDataAdapter(query, sql);
                    sqlData.SelectCommand.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("DATA UPDATED SUCCESSFULY");
                    regIDBox.Text = "";
                    FNameU.Text = "";
                    CellNoU.Text = "";
                    QualificationBOX.Text = "";
                    AddressU.Text = "";
                    SubjectBOX.Text = "";
                    ClassBox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string Query = "select * from faculty where TID = '" + regIDBox.Text + "'";
            dataSet = connection.select2(Query);


            foreach (DataRow r in dataSet.Tables[0].Rows)
            {

                //this..Text = r["Sid"].ToString();
                //this.AddmissionDate.Text = r["DOA"].ToString();
                this.FNameU.Text = r["FullName"].ToString();
                //this.L.Text = r["Lname"].ToString();
                //this.DobDate.Text = r["Dob"].ToString();
                //this.Genderbox.Text = r["Gender"].ToString();
                this.CellNoU.Text = r["Contact"].ToString();
                this.AddressU.Text = r["Address"].ToString();
                this.QualificationBOX.Text = r["Qualification"].ToString();
                // this.CnicBox.Text = r["Cnic"].ToString();
                this.SubjectBOX.Text = r["Subjects"].ToString();
                this.ClassBox.Text = r["Classes"].ToString();
                //this.FatherNameBOX.Text = r["FatherName"].ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            regIDBox.Text = "";
            FNameU.Text = "";
            CellNoU.Text = "";
            QualificationBOX.Text = "";
            AddressU.Text = "";
            SubjectBOX.Text = "";
            ClassBox.Text = "";
        }
    }
}
