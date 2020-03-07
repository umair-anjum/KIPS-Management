using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kips_Managment.User_Control
{
    public partial class Update_Student : UserControl
    {
        public Update_Student()
        {
            InitializeComponent();
        }

        private void Update_Student_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn ln = new LogIn();
            ln.Show();
        }
    }
}
