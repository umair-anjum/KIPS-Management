using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Kips_Managment.Forms
{
    public partial class Faculty : MetroFramework.Forms.MetroForm
    {
        LogIn obj = new LogIn();
        public Faculty()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
           update_Marks1.Hide();
            markattendence1.Hide();
            viewStudent1.Hide();
            attendence1.Show();
            change_Password1.Hide();
            mark_test1.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
           update_Marks1.Hide();
            markattendence1.Hide();
            viewStudent1.Hide();
            attendence1.Hide();
            change_Password1.Show();

            mark_test1.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            attendence1.Hide();
            mark_test1.Hide();
            update_Marks1.Hide();
            markattendence1.Hide();
            viewStudent1.Show();
            change_Password1.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
          update_Marks1.Hide();
            markattendence1.Show();
            viewStudent1.Hide();
            attendence1.Hide();
            mark_test1.Hide();
            change_Password1.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
           update_Marks1.Show();
            markattendence1.Hide();
            viewStudent1.Hide();
            attendence1.Hide();
            change_Password1.Hide();
            mark_test1.Hide();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            update_Marks1.Hide();
            markattendence1.Hide();
            viewStudent1.Hide();
            attendence1.Hide();
            change_Password1.Hide();
            mark_test1.Show();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            update_Marks1.Hide();
            markattendence1.Hide();
            viewStudent1.Hide();
            attendence1.Hide();
            change_Password1.Hide();
            mark_test1.Hide();
        }

        private void mark_test1_Load(object sender, EventArgs e)
        {

        }
    }
}
