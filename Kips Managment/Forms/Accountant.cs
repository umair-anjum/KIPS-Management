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
    public partial class Accountant : MetroFramework.Forms.MetroForm
    {
        public Accountant()
        {
            InitializeComponent();
        }
        LogIn obj = new LogIn();

        private void Accountant_Load(object sender, EventArgs e)
        {
            chkingStudentfee1.Hide();
            employeeSalaryPayment1.Hide();
            empoyeeSal_Info1.Hide();
            student_Fee_Collection1.Hide();
            change_Password1.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            chkingStudentfee1.Show();
            employeeSalaryPayment1.Hide();
            empoyeeSal_Info1.Hide();
            student_Fee_Collection1.Hide();
            change_Password1.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            chkingStudentfee1.Hide();
            employeeSalaryPayment1.Hide();
            empoyeeSal_Info1.Hide();
            student_Fee_Collection1.Show();
            change_Password1.Hide();
        }

        private void student_Fee_Collection1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            chkingStudentfee1.Hide();
            employeeSalaryPayment1.Show();
            empoyeeSal_Info1.Hide();
            student_Fee_Collection1.Hide();
            change_Password1.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            chkingStudentfee1.Hide();
            employeeSalaryPayment1.Hide();
            empoyeeSal_Info1.Show();
            student_Fee_Collection1.Hide();
            change_Password1.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            chkingStudentfee1.Hide();
            employeeSalaryPayment1.Hide();
            empoyeeSal_Info1.Hide();
            student_Fee_Collection1.Hide();
            change_Password1.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj.Show();
            
        }
    }
}
