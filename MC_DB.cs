using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp
{
    public class MC_DB
    {
        private static string HOST;
        private static string DATABASE;
        private static string USER;
        private static string PASS;
        private static string PORT;

        private MC_DB() { }

        public static MySqlConnection MyConnection()
        {
            var prop = new Properties();
            try
            {


                HOST = "localhost";
                PORT = "3306";
                DATABASE = "thegarage";
                USER = "root";
                PASS = "dcs2019";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ex1: Please DB Detaisl is Correct");
                return null;
            }

            var connectionString = $"Server={HOST};Port={PORT};Database={DATABASE};Uid={USER};Pwd={PASS};";
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed! Please Check Your Internet Connection");
                return null;
            }
        }

        public static string AddDataNoColumns(string tableName, string dataWithComa)
        {
            try
            {
                using (var connection = MyConnection())
                using (var command = new MySqlCommand($"INSERT INTO {tableName} VALUES ({dataWithComa})", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MC_database:AddDataNoColumns::");
                return ex.Message;
            }
            return "Success";
        }

        public static string AddDataWithColumns(string tableName, string columnsWithComa, string dataWithComa)
        {
            try
            {
                using (var connection = MyConnection())
                using (var command = new MySqlCommand($"INSERT INTO {tableName} ({columnsWithComa}) VALUES ({dataWithComa})", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MC_database:AddDataWithColumns::");
                return ex.Message;
            }
            return "Success";
        }

        public static DataTable SearchDataQuery(string sqlQuery)
        {
            try
            {
                using (var connection = MyConnection())
                using (var command = new MySqlCommand(sqlQuery, connection))
                using (var adapter = new MySqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MC_database:SearchDataQuery::");
                return null;
            }
        }

        public static void InsertData(string sqlQuery)
        {
            try
            {
                using (var connection = MyConnection())
                using (var command = new MySqlCommand(sqlQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MC_database:InsertData::");
            }
        }

        public static string UpdateDataWithSearch(string tableName, string updateColumns, string whereColumnName, string searchValue)
        {
            try
            {
                using (var connection = MyConnection())
                using (var command = new MySqlCommand($"UPDATE {tableName} SET {updateColumns} WHERE {whereColumnName} = {searchValue}", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MC_database:UpdateDataWithSearch::");
                return ex.Message;
            }
            return "Success";
        }

        public static DataTable SearchDataAll(string tableName, string columnName, string whereValue)
        {
            string sqlQuery = $"SELECT * FROM {tableName} WHERE {columnName} = '{whereValue}'";
            return SearchDataQuery(sqlQuery);
        }

        public static DataTable SearchDataOne(string tableName, string columnName, string whereValue)
        {
            string sqlQuery = $"SELECT * FROM {tableName} WHERE {columnName} = '{whereValue}'";
            return SearchDataQuery(sqlQuery);
        }

        public static DataTable SearchAllUseTable(string tableName)
        {
            string sqlQuery = $"SELECT * FROM {tableName}";
            return SearchDataQuery(sqlQuery);
        }

        public static long InsertDataWithGetLastID(string tableName, string columnsWithComa, string valuesWithComa)
        {
            long insertId = 0;
            try
            {
                using (var connection = MyConnection())
                {
                    var query = $"INSERT INTO {tableName} ({columnsWithComa}) VALUES ({valuesWithComa}); SELECT LAST_INSERT_ID();";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        insertId = Convert.ToInt64(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MC_database:InsertDataWithGetLastID::");
            }
            return insertId;
        }

        public class Properties
        {
            private readonly System.Collections.Specialized.NameValueCollection properties = new System.Collections.Specialized.NameValueCollection();

            public void Load(string filePath)
            {
                foreach (var row in File.ReadAllLines(filePath))
                {
                    var keyValue = row.Split('=');
                    properties.Add(keyValue[0].Trim(), keyValue[1].Trim());
                }
            }

            public string this[string property]
            {
                get { return properties[property]; }
            }
        }
    }
}
