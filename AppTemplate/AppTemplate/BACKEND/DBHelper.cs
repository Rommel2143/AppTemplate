using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace AppTemplate.BACKEND
{
    public static class DBHelper
    {
        private static readonly string connStr = "server=localhost;port=3306;user id=root;password=;database=appdb";

        private static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        // SELECT - returns DataTable
        public static DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable table = new DataTable();
            using (MySqlConnection con = GetConnection())
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Query execution failed: " + ex.Message);
                }
            }
            return table;
        }

        // INSERT, UPDATE, DELETE - returns affected rows
        public static int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            int rowsAffected = 0;
            using (MySqlConnection con = GetConnection())
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Non-query execution failed: " + ex.Message);
                }
            }
            return rowsAffected;
        }
    }
}
