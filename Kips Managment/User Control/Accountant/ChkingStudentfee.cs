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
    public partial class ChkingStudentfee : UserControl
    {
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");
        public ChkingStudentfee()
        {
            InitializeComponent();
        }

        private void ChkingStudentfee_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            sql.Open();
            string query="select * from studentfee where invoiceID = '"+invobox.Text+"'";
            SqlDataAdapter dap = new SqlDataAdapter(query,sql);
            DataTable table = new DataTable();
            dap.Fill(table);
            dataGridView1.DataSource = table;
            sql.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            invobox.Text = "";
        }
    }
}
