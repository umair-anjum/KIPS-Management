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
using System.Speech.Synthesis;
namespace Kips_Managment.User_Control.faculty
{
    public partial class markattendence : UserControl
    {
        DbConnection connection = new DbConnection();
        string cid;
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public markattendence()
        {
            InitializeComponent();
            cid = LogIn.txt;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string quer = "select Sid from student";
            Console.WriteLine(quer);
            table = connection.select(quer);
            if (table.Rows[0][0].ToString() != attenbox.Text)
            {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                speechSynthesizer.Speak("The following Student does not exists!");
                MessageBox.Show("The following Student does not exists");
            }
            else
            {
                try
                {
                    string query = "insert into attendence(TID,SID,ASTATUS,Date) values('" + cid + "','" + attenbox.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Value.Date + "') ";
                    Console.WriteLine(query);
                    connection.insert(query);
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                    speechSynthesizer.Speak("Attendence Updated!");
                  
                    MessageBox.Show("Attendence Updated");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
