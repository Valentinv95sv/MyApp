using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DatabaseDLL
{
    public class DbClass
    {
        private MySqlConnection _connection;
        private string message;

        //подключение к СУБД
        public void Connect(string username, string password, string Database)
        {
            
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
        
        //открыть соединение с СУБД
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
        
        //закрыть соединение с СУБД
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
        
        //создать БД
        public void CreateDB(string DBName)
        {
            string query = String.Format("CREATE DATABASE IF NOT EXISTS {0};", DBName);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                
                this.CloseConnection();
            }
        }
        
        //удалить БД
        public void DeleteDB(string DBName)
        {
            string query = String.Format("DROP DATABASE IF EXISTS {0}", DBName);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }
        
        //создать таблтцу с полями
        public void CreateTable(string TableName, string[] columns)
        {
            //создание таблицы со столбцами
            string query = String.Format("CREATE TABLE {0} (", TableName);
            foreach (var i in columns)
            {
                string[] a = i.Split(':');
                query += String.Format("{0} {1} DEFAULT '#####',", a[0], a[1]);
            }
            query = query.Remove(query.Length - 1);
            query += ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";
            
            //вставка значения ##### в первую ячейку каждого столбца
            string query2 = String.Format("INSERT INTO TABLE {0} ", TableName);
            foreach (var i in columns)
            {
                query += String.Format("{0}, ", i.Split(':')[0]);
            }
            query.Remove(query.Length - 1);
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        
        //удалить таблицу
        public void DeleteTable(string TableName)
        {
            string query = String.Format("DROP TABLE IF EXISTS {0}", TableName);

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        
        //получить все записи из таблицы
        public string[][] Select(string table)
        {
            string query = "SELECT * FROM " + table;
            string mystring = null;
            int count = 0;
            string[] a = new string[]{};
            string[][] output = new string[3][];
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        for (int j = 0; j < dataReader.FieldCount; j++)
                        {
                            if (j == dataReader.FieldCount - 1)
                            {
                                mystring += dataReader[j];
                            }
                            else
                            {
                                mystring += dataReader[j] + ",";
                            }
                            
                        }
                        mystring += ";";
                    }
                    a = mystring.Split(';');
                    output = new string[a[0].Split(',').Length][];
                    for (int j = 0; j < a[0].Split(',').Length; j++)//вправо
                    {
                        string[] b = new string[a.Length];
                        for (int i = 0; i < a.Length - 1; i++)//вниз
                        {
                            b[i] =  a[i].Split(',')[j];
                        }

                        output[j] = b;
                    }
                    
                    dataReader.Close();
                    this.CloseConnection();
                    return output;
                }
            }
            return output;
        }
        
        //втсавить записи в таблицу
        public void Insert(string TableName, string[] i, string[] columns)
        {
            
            string query = String.Format("INSERT INTO {0} (", TableName);
            foreach (var j in columns)
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
        
        //отчистить таблицу
        public void deleteAll(string Tablename)
        {
            //string query = "TRUNCATE TABLE mytable";
            string query = String.Format("TRUNCATE TABLE {0}", Tablename);
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}