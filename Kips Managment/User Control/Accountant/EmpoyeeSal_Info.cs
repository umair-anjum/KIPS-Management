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
namespace Kips_Managment.User_Control
{
    public partial class EmpoyeeSal_Info : UserControl
    {
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");
        public EmpoyeeSal_Info()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            sql.Open();
            string query = "select * from Facultypay where EmployeeID ='"+empIDBox.Text+"'";
            SqlDataAdapter dap = new SqlDataAdapter(query, sql);
            DataTable table = new DataTable();
            dap.Fill(table);
            dataGridView1.DataSource = table;
            sql.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            empIDBox.Text = "";
        }
    }
}
