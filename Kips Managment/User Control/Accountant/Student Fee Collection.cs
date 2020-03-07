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
    public partial class Student_Fee_Collection : UserControl
    {
        DbConnection connection = new DbConnection();
        SqlConnection obj = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");
        public Student_Fee_Collection()
        {
            InitializeComponent();
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Open();
                string query = "insert into studentfee(invoiceID,StudentID,StudentName,Date,amount,class) values ('" + invoicebox.Text + "','" + StdID.Text + "','" + STDName.Text + "','" + dateTimePicker1.Value.Date+ "','" + AmountBox.Text + "','" + classbox.Text + "')";
                Console.WriteLine(query);
                connection.insert(query);
                SqlDataAdapter adap = new SqlDataAdapter(query, obj);
                adap.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Fee paid Successfully");
                obj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
