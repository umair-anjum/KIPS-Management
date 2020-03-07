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

namespace Kips_Managment.User_Control.faculty
{
    public partial class Attendence : UserControl
    {
        string cid;
        DbConnection onnection = new DbConnection();
        public Attendence()
        {
            InitializeComponent();
            cid = LogIn.txt;
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string query = "select * from attendence where SID ='"+stdbox.Text+"'AND TID ='"+cid+"'";
            Console.WriteLine(query);
           table=onnection.select(query);
            dataGridView1.DataSource = table;
            stdbox.Text = "";
        }
    }
}
