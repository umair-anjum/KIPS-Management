using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Data.SqlClient;

namespace Speak.StartingControls
{
    public partial class Manager : UserControl
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btncan_Click(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=desktop-9g16don\sqlserver;Initial Catalog=acadmy;Integrated Security=True;");
            sql.Open();
            string query = "Select Count(*) From Manager Where Name = '" + Mname.Text + "' And Password = '" + Mpass.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            //adapter.SelectCommand.ExecuteNonQuery();
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows[0][0].ToString() == "1")
            {
                ManagerDashBoard dashBoard = new ManagerDashBoard();
                this.Hide();
                dashBoard.Show();
            }
            else
            {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                speechSynthesizer.Speak("Enter Correct Password!");
                MessageBox.Show("Please Enter Correct User Name and Password");
            }
        }
    }
}
