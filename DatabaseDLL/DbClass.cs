using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseDLL
{
    public class DbClass
    {
        private MySqlConnection _connection;
        private string message;

        public void Connect(string username, string password, string Database)
        {
            //string connectionString = "SERVER=" + "localhost" + ";" + "DATABASE=" + "arduinodatabase" + ";" +
                                      //"UID=" + username + ";" + "PASSWORD=" + password + ";";
                                      
            string connectionString = "SERVER=" + "localhost" + ";" + "DATABASE=" + Database + ";" +
                                      "UID=" + username + ";" + "PASSWORD=" + password + ";";
            
            
            try
            {
                _connection = new MySqlConnection(connectionString);
                MessageBox.Show("connected");
                if (this.OpenConnection())
                {
                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        message = "Cannot connect to server";
                        break;
                    
                    case 1045:
                        message = "Invalid username/password";
                        break;
                }
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                message = ex.Message;
                return false;
            }
        }

        
       public List<string> Select(string[] ColumNames)
        {
            string query = "SELECT * FROM mytable";
            List<string> list = new List<string>();
            string mystring = null;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    foreach (var i in ColumNames)
                    {
                        mystring += dataReader[i.ToString()] + " | ";
                    }
                    list.Add(mystring);
                    mystring = null;
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
       
       public List<string> selectLastFive(string[] ColumName)
       {
           List<string> list = new List<string>();
           list = this.Select(ColumName);
           list = Enumerable.Reverse(list).Take(5).Reverse().ToList();
           return list;
       }       

        public void Insert(string[] i, string[] table)
        {
            
            string query = "INSERT INTO mytable (";
            foreach (var j in table)
            {
                string z = String.Format("{0},", j);
                query += z;
            }

            query = query.Remove(query.Length - 1);
            query += " ) VALUES (";
            
            foreach (var k in i)
            {
                string y;
                y = String.Format("{0},", k );  
                query += y;
                }

            query = query.Remove(query.Length - 1);
            
            query += ")";
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Update()
        {
            string query = "UPDATE mytable SET test = 'hello' WHERE test = '32'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Delete()
        {
            string query = "DELETE FROM mytable ORDER BY 'test' DESC LIMIT 1";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public int Count()
        {
            string query = "SELECT Count(*) FROM mytable";
            int Count = -1;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();
                return Count;
            }
            else
            {
                return Count;
            }
        }

        public string getmessage()
        {
            return message;
        }

        public void deleteAll()
        {
            string query = "TRUNCATE TABLE mytable";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}