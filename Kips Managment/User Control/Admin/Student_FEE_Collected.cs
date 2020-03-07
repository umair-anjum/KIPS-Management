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


namespace Kips_Managment.User_Control.Admin
{
    public partial class Student_FEE_Collected : UserControl
    {
        public Student_FEE_Collected()
        {
            InitializeComponent();
        }
        DbConnection connection = new DbConnection();
        private void button1_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();


            DataSet dataSet = new DataSet();

            string query = "select * from studentfee";
           
            Console.WriteLine(query);
            table = connection.select(query);

            dataGridView1.DataSource = table;
           

            int sum = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            textBox1.Text = sum.ToString();
            // this.TotalBOX.Text = ;


        }
    }
}
