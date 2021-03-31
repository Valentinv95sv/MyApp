using System;
using System.Data;
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
                //MessageBox.Show("connected");
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
            this.CloseConnection();
            string query = String.Format("DROP DATABASE IF EXISTS {0}", DBName);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }
        
        //создать таблтцу с полями
        public Boolean CreateTable(string TableName, string[] columns)
        {
            this.CloseConnection();
            
            //создание таблицы со столбцами
            string query = String.Format("CREATE TABLE {0} (", TableName);
            foreach (var i in columns)
            {
                string[] a = i.Split(':');
                query += String.Format("{0} {1} DEFAULT NULL,", a[0], a[1]);
            }
            query = query.Remove(query.Length - 1);
            query += ")";  // ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";
            
            //вставка значения ##### в первую ячейку каждого столбца
            string query2 = String.Format("INSERT INTO {0} (", TableName);
            foreach (var i in columns)
            {
                query2 += String.Format("{0},", i.Split(':')[0]);
            }
            query2 = query2.Remove(query2.Length - 1);
            query2 += ") VALUES (";
            foreach (var i in columns)
            {
                query2 += "'#####',";
            }
            query2 = query2.Remove(query2.Length - 1);
            query2 += ")";
            
            //проверка на правильность создания
            string query3 = "SELECT * FROM " + TableName;
            string[] b = new string[columns.Length];
            for (int i = 0; i < columns.Length - 1; i++)
            {
                b[i] = columns[i].Split(':')[0];
            }
            string[] z = new string[b.Length];
            
            Boolean check = false;
            
            if (this.OpenConnection() == true)
            {
                var cmd = new MySqlCommand();
                cmd.Connection = _connection;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();
                
                MySqlCommand cmd2 = new MySqlCommand(query3, _connection);
                MySqlDataReader reader = cmd2.ExecuteReader();
                
                while (reader.Read())
                {
                    for (int i = 0; i < columns.Length; i++)
                    {
                        string a = reader.GetValue(i).ToString();
                        z[i] = a;
                    }

                }
                reader.Close();
                foreach (var i in z)
                {
                    if (i == "#####")
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }

                string query4 = String.Format("TRUNCATE TABLE {0}", TableName);
                cmd.CommandText = query4;
                cmd.ExecuteNonQuery();
                
                this.CloseConnection();
            }
            
            return check;
        }

        //удалить таблицу
        public void DeleteTable(string TableName)
        {
            this.CloseConnection();
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
            this.CloseConnection();
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
        public void Insert(string TableName, string[] values, string[] columns)
        {
            
            string query = String.Format("INSERT INTO {0} (", TableName);
            foreach (var j in columns)
            {
                string z = String.Format("{0},", j);
                query += z;
            }

            query = query.Remove(query.Length - 1);
            query += " ) VALUES (";
            
            foreach (var k in values)
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

        public void InsertInColumns(string TableName, string[] data, string columns)
        {
            string query = String.Format("INSERT INTO {0} ()", TableName);
            
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