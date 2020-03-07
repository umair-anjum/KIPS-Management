using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace KipsManagment.MODEL
{
    class DbConnection
    {
         public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DbConnection()
        {
            Initialize();
        }

        public void Initialize()
        {
            server = "localhost";
            database = "kips";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "SslMode=none;";

            connection = new MySqlConnection(connectionString);
        }
         public bool OpenConnection()
         {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:

                        break;

                    case 1045:

                        break;
                }
                return false;
            }
        }
         public void CloseConnection()
         {
                 connection.Close();
         }
         public void insert(string query)
         {
             if (this.OpenConnection())
             {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    // MessageBox.Show(query);
                    cmd.ExecuteNonQuery();

                    this.CloseConnection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }

         }
         public void update(string query)
         {
             if (this.OpenConnection())
             {
                 MySqlCommand cmd = new MySqlCommand(query, connection);
                // MessageBox.Show(query);
                 cmd.ExecuteNonQuery();
                
                 this.CloseConnection();
             }
         }
         public void delete(string query)
         {
             if (this.OpenConnection())
             {
                 MySqlCommand cmd = new MySqlCommand(query, connection);

                 cmd.ExecuteNonQuery();

                 this.CloseConnection();
             }
         }
         public int count(string query)
         {
             int count = -1;
             if (this.OpenConnection())
             {
                 MySqlCommand cmd = new MySqlCommand(query, connection);
                 count = int.Parse(cmd.ExecuteScalar() + "");
                 this.CloseConnection();
                 return count;
             }
             return count;
         }
         public DataTable select(string query)
         {
             DataSet ds = new DataSet();
            DataTable table = new DataTable();
            if (this.OpenConnection())
             {
                 MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                
                 adapter.Fill(table);
                // MessageBox.Show(query);
                 this.CloseConnection();
                 return table;
             }
            Console.WriteLine("Connection is not open");
             return table;
         }
        public DataSet select2(string query)
        {
            DataSet ds = new DataSet();
           
               
                // DataTable table = new DataTable();
                if (this.OpenConnection())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                    adapter.Fill(ds);
                    // MessageBox.Show(query);
                    this.CloseConnection();
                    return ds;
                }
                Console.WriteLine("Connection is not open");
               
            
         
            return ds;
        }
    }
}
