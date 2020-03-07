using Kips_Managment.User_Control;
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
    public partial class Admission : MetroFramework.Forms.MetroForm
    {
        public Admission()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new_Admission1.Hide();
            update_Student1.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            update_Student1.Hide();
            new_Admission1.Show();   
           
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn ln = new LogIn();
            ln.Show();
        }

        private void Admission_Load(object sender, EventArgs e)
        {

        }
    }
}
