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
using System.Data.SqlClient;

namespace Kips_Managment.User_Control.faculty
{
    public partial class ViewStudent : UserControl
    {
        DbConnection connection = new DbConnection();
        string cid;
        public ViewStudent()
        {
            InitializeComponent();
           cid = LogIn.txt;
        }

        private void ViewBTN_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
           string query = "select Sid,Fname,Lname,Section,Class from student where Sid = (select StdID from cources where TeacherID = '"+cid+"')";

           // string query = ("select * from cources");
            

             Console.WriteLine(query);
            dataTable = connection.select(query);
            dataGridView1.DataSource = dataTable;
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
         
        }
    }
}
