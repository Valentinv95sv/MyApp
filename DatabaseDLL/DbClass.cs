﻿using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DatabaseDLL
{
    public class DbClass
    {
     private MySqlConnection _connection;
     private string message;
    
        public void Connect(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
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
        
        public List<string> Select()
        {
            string query = "SELECT * FROM mytable";
            List<string> list = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader["test"] + "");
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
        
        public void Insert(string i)
        {
            string query = "INSERT INTO mytable (test) VALUES (" + i + ")";
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
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = _connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Delete()
        {
            string query = "DELETE FROM mytable WHERE test='23'";
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
    }
}