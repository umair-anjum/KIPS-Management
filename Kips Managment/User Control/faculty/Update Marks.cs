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
    public partial class Update_Marks : UserControl
    {
        DbConnection connection = new DbConnection();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        string a;
        public Update_Marks()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val="";
            if (comboBox1.Text=="Pass")
            {
                val = "pass";
            }
            else if(comboBox1.Text == "Fail")
            {
                val = "fail";
            }
            if (paperbox.Text == ""
              || totalmarks.Text == ""
            || Omarks.Text == ""
            || Sbox.Text == ""
            || Cbox.Text == "" || comboBox1.Text == "")
            {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                speechSynthesizer.Speak("Please fill the empty Information!");
                MessageBox.Show("Please fill the empty Information");
            }

            DataTable table1 = new DataTable();
           
                string quer1 = "select Sid from student";
                Console.WriteLine(quer1);
                table1 = connection.select(quer1);
                if (table1.Rows[0][0].ToString() != Sbox.Text)
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                    speechSynthesizer.Speak("The following Student does not exists!");
                    MessageBox.Show("The following Student does not exists");

                }
            
           
            /* DataSet ds = new DataSet();
             string query = "select CName from cources where CourseID = '"+Cbox.Text +"' ";
             Console.WriteLine(query);
           ds=connection.select2(query);
             foreach (DataRow r in ds.Tables[0].Rows)
             {
               a=  r["CName"].ToString();
             }*/
            
                DataTable table = new DataTable();
                string quer = "select CName from cources where  CourseID = '" + Cbox.Text + "'";
                Console.WriteLine(quer);
                table = connection.select(quer);
                a = table.Rows[0][0].ToString();
                if (paperbox.Text == "" || totalmarks.Text == "" || Omarks.Text == "" || Sbox.Text == "" || Cbox.Text == "")
                {
                    MessageBox.Show("Please Fill the Required Fields");
                }
                else
                {
                    try
                    {
                    
                        string query1 = "insert into finals(ExamID,CName,Tmarks,Omarks,StdID,CourseID,Sresult) values ('" + paperbox.Text + "','" + a + "','" + totalmarks.Text + "','" + Omarks.Text + "','" + Sbox.Text + "','" + Cbox.Text + "','"+val+"')";
                        Console.WriteLine(query1);
                        connection.insert(query1);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                    speechSynthesizer.Speak("Marks inserted!");
                    MessageBox.Show("Marks inserted");
                    paperbox.Text = "";
                    totalmarks.Text = "";
                    Omarks.Text = "";
                    Sbox.Text = "";
                    Cbox.Text = "";
                comboBox1.Text = "";
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string query="select * from finals where stdID='"+Sbox.Text+"'";
            Console.WriteLine(query);
            table = connection.select(query);
            dataGridView1.DataSource = table;
            
        }
    }
}
