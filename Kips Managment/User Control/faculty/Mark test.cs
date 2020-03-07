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
    public partial class Mark_test : UserControl
    {
        DbConnection connection = new DbConnection();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public Mark_test()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into testmarks(SID,TID,ObtainedMarks,totalmarks,TstID) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + tstID.Text + "')";
           
             Console.WriteLine(query);
            connection.insert(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
            speechSynthesizer.Speak("Test Marks Updated!");
             MessageBox.Show("Test Marks Updated Successfully");
            textBox1.Text = "";
            textBox2.Text = "";
            tstID.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }
    }
}
