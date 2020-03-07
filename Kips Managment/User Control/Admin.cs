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
    public partial class Admin : UserControl
    {
        SpeechSynthesizer s = new SpeechSynthesizer();
        
        public Admin()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=desktop-9g16don\sqlserver;Initial Catalog=acadmy;Integrated Security=True;");
            sql.Open();
            string query = "Select Count(*) From Manager Where Name = '" + textBox1.Text + "' And Password = '" + textBox2.Text + "'";
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
                s.SelectVoiceByHints(VoiceGender.Female);
                s.Speak("Try Again!");
                MessageBox.Show("Please Enter Correct User Name and Password");
            }
        }
    }
}
