using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KipsManagment.MODEL;
using MetroFramework.Forms;

namespace Kips_Managment.Forms
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        LogIn obj = new LogIn();
        public Admin()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            adD_Manager1.Show();
            dlT_UP_Manager1.Hide();
            faculty_Pay_REport1.Hide();
            student_FEE_Collected1.Hide();
            change_Password1.Hide();

        }

        private void adD_Manager1_Load(object sender, EventArgs e)
        {

          


        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            adD_Manager1.Hide();
            dlT_UP_Manager1.Show();
            faculty_Pay_REport1.Hide();
            student_FEE_Collected1.Hide();
            change_Password1.Hide();
            profit1.Hide();

        }

        private void dlT_UP_Manager1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            change_Password1.Hide();
            adD_Manager1.Hide();
            dlT_UP_Manager1.Hide();
            faculty_Pay_REport1.Show();
            student_FEE_Collected1.Hide();
            profit1.Hide();
        }

        private void faculty_Pay_REport1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            adD_Manager1.Hide();
            dlT_UP_Manager1.Hide();
            faculty_Pay_REport1.Hide();
            student_FEE_Collected1.Show();
            change_Password1.Hide();
            profit1.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            profit1.Hide();
            adD_Manager1.Hide();
            dlT_UP_Manager1.Hide();
            faculty_Pay_REport1.Hide();
            student_FEE_Collected1.Hide();
            change_Password1.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            profit1.Hide();
            adD_Manager1.Hide();
            dlT_UP_Manager1.Hide();
            faculty_Pay_REport1.Hide();
            student_FEE_Collected1.Hide();
            change_Password1.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            profit1.Show();
            adD_Manager1.Hide();
            dlT_UP_Manager1.Hide();
            faculty_Pay_REport1.Hide();
            student_FEE_Collected1.Hide();
            change_Password1.Hide();
        }
    }
}
