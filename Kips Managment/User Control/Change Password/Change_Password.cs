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
using System.Data.SqlClient;

namespace Kips_Managment.User_Control
{
    public partial class Change_Password : UserControl
    {
        DbConnection connection = new DbConnection();
        string Cid;

        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-RGBJ83K\SQLEXPRESS;Initial Catalog=kips;Integrated Security=True;");
        LogIn obj = new LogIn();

        /* public Change_Password(string id)
         {
             InitializeComponent();
             Cid = id;
         }*/
        public Change_Password()
        {
            InitializeComponent();
            Cid = LogIn.txt;
            NEW_PASS.Text = "";
            NEW_PASS.PasswordChar = '*';
            NEW_PASS.MaxLength = 25;
            CNFRM_PASS.Text = "";
            CNFRM_PASS.PasswordChar = '*';
            CNFRM_PASS.MaxLength = 25;

        }
        private void Change_Password_Load(object sender, EventArgs e)
        {

        }

        private void CHange_PASS_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string LID;

            try
            {

                sql.Open();
                /* string query = "select Password from Login where Name = '"+Cid+"'";

                 SqlDataAdapter sqlData = new SqlDataAdapter(query, sql);
                 DataTable table = new DataTable();
                 //     LID=  dataSet.Tables[0].Rows[0].Columns[0].ToString();
                 sqlData.Fill(table);
                 LID = table.Rows[0][0].ToString();
                 //Console.WriteLine(LID);
                 if (LID == null)
                 {
                     MessageBox.Show("Query ID is null");
                 }*/



                if (NEW_PASS.Text == CNFRM_PASS.Text)
                {
                    string query1 = "update Login set  Password = '" + NEW_PASS.Text + "' where Name= '" + Cid + "'";
                    SqlDataAdapter sqlDat = new SqlDataAdapter(query1, sql);
                    sqlDat.SelectCommand.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("Password Updated");
                }
                else
                {
                    MessageBox.Show("Check Password plz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
            
            }
        }
    }

        
    

