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

namespace Kips_Managment.User_Control.Admin
{
    public partial class DLT_UP_Manager : UserControl
    {
        DbConnection connection = new DbConnection();
        public DLT_UP_Manager()
        {
            InitializeComponent();
        }

        private void DLT_UP_Manager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (deleteRadio.Checked)
            {
                string query = "Delete from manager where MID= '" + MIDbox.Text + "'";
                Console.WriteLine(query);
                connection.delete(query);
                MessageBox.Show("Deleted successfully !!!");


            }
            else if (UpdateRadio.Checked)
            {
                try
                {
                    string query1 = "update manager set FullName = '" + Fnamebox.Text + "', PhoneNO = '" + CellNObox.Text + "'," +
                            "Address = '" + Addressbox.Text + "', Qualification = '" + QualifBOX.Text + "'," +
                            "Password = '" + PasswordBOx.Text + "' where MID ='" + MIDbox.Text + "' ";
                    Console.WriteLine(query1);
                    connection.delete(query1);
                    MessageBox.Show("Updated successfully !!!");
                     MIDbox.Text = "";
            Fnamebox.Text = "";
            PasswordBOx.Text = "";
            QualifBOX.Text = "";
            CellNObox.Text="";
            Addressbox.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select the Option Above !!!!");
            }
            }

        private void Viewbtn_Click(object sender, EventArgs e)
        {

            DataSet dataSet = new DataSet();
            string Query = "select * from manager where MID = '" + MIDbox.Text + "'";
            dataSet = connection.select2(Query);


            foreach (DataRow r in dataSet.Tables[0].Rows)
            {

                //this..Text = r["Sid"].ToString();
                //this.AddmissionDate.Text = r["DOA"].ToString();
                this.Fnamebox.Text = r["FullName"].ToString();

                this.CellNObox.Text = r["PhoneNO"].ToString();
                this.Addressbox.Text = r["Address"].ToString();
                this.PasswordBOx.Text = r["Password"].ToString();
                // this.CnicBox.Text = r["Cnic"].ToString();
                this.QualifBOX.Text = r["Qualification"].ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MIDbox.Text = "";
            Fnamebox.Text = "";
            PasswordBOx.Text = "";
            QualifBOX.Text = "";
            CellNObox.Text="";
            Addressbox.Text = "";

        }
    }

      /*  private void Viewbtn_Click(object sender, EventArgs e)
        {
        }*/
    }

