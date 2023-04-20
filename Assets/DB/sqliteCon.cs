using System;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using Mono.Data.Sqlite;
using TMPro;
using System.IO;

namespace Assets
{
    internal class ConfigConnect
    {
        public string path = "/DB/StrangeTest.db";
    }
    internal class sqliteCon : MonoBehaviour
    {
        TMP_InputField login;
        TMP_InputField password;
        SqliteConnection connection;

        public string log = "";
        public string pass = "";

        string path = Application.dataPath + "/config.json";
        void Start()
        {
            string json;
            using(StreamReader sw = new StreamReader(path))
            {
                json = sw.ReadToEnd();
            }
            ConfigConnect configConnect = JsonUtility.FromJson<ConfigConnect>(json);
            Debug.Log(configConnect.path);
            ConnectToDB();
            //SelectDataFromTable();
        }
        public void Register()
        {
            string sqlQuery = $"INSERT INTO DataUsers(login, password, email, role) VALUES ('{log}', '{pass}', 'sdsda', 'student')";

            SqliteCommand command = new SqliteCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }
        public void Enter()
        {
            //string sqlQuery = $"SELECT * FROM DataUsers WHERE login = '{login.text}' AND password = '{password.text}'";
            string sqlQuery = $"SELECT role FROM DataUsers WHERE login = '{log}' AND password = '{pass}'";

            SqliteCommand command = new SqliteCommand(sqlQuery, connection);
            SqliteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Debug.Log($"Вы успешно вошли, с ролью {reader["role"].ToString()}");
            }
            reader.Close();
            command.Dispose();
            //SqliteDataAdapter
        }
        void ConnectToDB()
        {
            string connString = $"Data Source={Application.dataPath + "/DB/StrangeTest.db"}";
            connection = new SqliteConnection(connString);
            connection.Open();
        }
        void SelectDataFromTable()
        {
            try
            {
                string sqlQuery = "SELECT * FROM DataUsers";
                SqliteCommand command = new SqliteCommand(sqlQuery, connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string data = reader["login"].ToString();
                    Debug.Log(data);
                }
                reader.Close();
                command.Dispose();
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
        private void OnEnable()
        {
            connection?.Open();
        }
        private void OnDisable()
        {
            connection?.Close();
        }
        void CreateMySQL()
        {
            //string connectionString = "Server=localhost;Database=SDBtest;Uid=root;Pwd=;";

            //connection = new MySqlConnection(connectionString);

            //try
            //{

            //    connection.Open();

            //    string query = "SELECT * FROM users";
            //    MySqlCommand command = new MySqlCommand(query, connection);

            //    Debug.Log(command.ExecuteScalar().ToString());

            //}
            //catch (MySqlException e)
            //{

            //    Debug.Log("MySQL Error: " + e.Message);

            //}
        }
    }
}
