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
    public partial class EmployeeSalaryPayment : UserControl
    {
        DbConnection connection = new DbConnection();
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");
        public EmployeeSalaryPayment()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            sql.Open();

           string query = "insert into Facultypay(EmployeeID,Salary,Date) values ('"+IDBOX.Text+"','"+SalaryBOX.Text+"','"+DOPPicker.Value.Date+"')";
            Console.WriteLine(query);
            connection.insert(query);
            SqlDataAdapter dap = new SqlDataAdapter(query, sql);
            dap.SelectCommand.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Salary paid");
        }

        private void EmployeeSalaryPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
