using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kips_Managment.User_Control;
using MetroFramework.Forms;

namespace Kips_Managment.Forms
{
    public partial class Manager : MetroFramework.Forms.MetroForm
    {
        public Manager()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void Manager_Load(object sender, EventArgs e)
        {

            metroComboBox2.SelectedIndex = 0;
            metroComboBox1.SelectedIndex = 0;
            new_Admission1.Hide();
            newEmployee1.Hide();
            change_Password1.Hide();
            updateStudent1.Hide();
            viewFaculty1.Hide();
            vIew_Student1.Hide();
            updateFaculty1.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new_Admission1.Show();
            newEmployee1.Hide();
            change_Password1.Hide();
            updateStudent1.Hide();
            viewFaculty1.Hide();
            vIew_Student1.Hide();
            updateFaculty1.Hide();




        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new_Admission1.Hide();
            newEmployee1.Show();
            change_Password1.Hide();
            updateStudent1.Hide();
            updateFaculty1.Hide();
            viewFaculty1.Hide();
            vIew_Student1.Hide();


        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            new_Admission1.Hide();
            newEmployee1.Hide();
            updateFaculty1.Hide();
            change_Password1.Hide();
            updateStudent1.Show();
            viewFaculty1.Hide();
            vIew_Student1.Hide();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            new_Admission1.Hide();
            newEmployee1.Hide();
            updateFaculty1.Hide();
            change_Password1.Hide();
            updateStudent1.Hide();
            viewFaculty1.Hide();
            vIew_Student1.Show();


        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            new_Admission1.Hide();
            updateFaculty1.Hide();
            newEmployee1.Hide();
            change_Password1.Hide();
            updateStudent1.Hide();
            viewFaculty1.Show();
            vIew_Student1.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            new_Admission1.Hide();
            updateFaculty1.Show();
            newEmployee1.Hide();
            change_Password1.Hide();
            updateStudent1.Hide();
            viewFaculty1.Hide();
            vIew_Student1.Hide();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            new_Admission1.Hide();
            updateFaculty1.Hide();
            newEmployee1.Hide();
            change_Password1.Show();
            updateStudent1.Hide();
            viewFaculty1.Hide();
            vIew_Student1.Hide();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            this.Hide();
            log.Show();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
                case 1:
                   metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;

            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
        }
    }
}
