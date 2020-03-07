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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace Kips_Managment.User_Control.Admin
{
    public partial class Faculty_Pay_REport : UserControl
    {
        public Faculty_Pay_REport()
        {
            InitializeComponent();
        }
        DbConnection connection = new DbConnection();

       SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            DataTable table = new DataTable();
             DataSet dataSet = new DataSet();

            string query = "select * from Facultypay";
            string query1 = "select sum(Salary) from Facultypay";
            dataSet = connection.select2(query1);
            Console.WriteLine(query);
           table= connection.select(query);
            
            dataGridView1.DataSource = table;

            double income = 0;
            DataTable dt = new DataTable();
            sql.Open();
            
            int sum=0;
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            TotalBOX.Text = sum.ToString();
            // this.TotalBOX.Text = ;



        }

        private void TotalBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
