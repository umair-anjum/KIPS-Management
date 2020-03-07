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

namespace Kips_Managment.User_Control.Admin
{
    public partial class profit : UserControl
    {
        DbConnection connection = new DbConnection();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public profit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string z="";
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();

            string quer = "select sum(amount) from studentfee ";
            string query = "select sum(Salary) from facultypay";

            Console.WriteLine(quer);
            table = connection.select(quer);
            Console.WriteLine(query);   
            table1 = connection.select(query);




          /*  double income = 0;
            DataTable dt = new DataTable();*/

             STDFEEBOX.Text = table.Rows[0][0].ToString()  ;
            teachpay.Text = table1.Rows[0][0].ToString();
            int a = Convert.ToInt32(STDFEEBOX.Text);

            int b = Convert.ToInt32(teachpay.Text);
            int c = a - b;
            if (c<=0)
            {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                speechSynthesizer.Speak("Your Institutue is in Loss!");
          

                MessageBox.Show("Your Institutue is in Loss");
            }
           else if (c > 0)
            {
                speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                speechSynthesizer.Speak("Your Institutue is in Profits!");


                MessageBox.Show("Your Institutue is in Profit");
            }

            resultbox.Text = Convert.ToString(c);


            /*  int sum = 0;
              for (int i = 0; i < table.; i++)
              {
                  sum += table.Rows[i][0].ToString()
              }
              TotalBOX.Text = sum.ToString();*/
        }
    }
}
