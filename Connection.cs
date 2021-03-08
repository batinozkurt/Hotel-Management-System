using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace FinalProject
{
    class Connection
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel_database");
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlCommand getCommand()
        {
            return command;
        }
        public SqlDataAdapter getAdapter()
        {
            return adapter;
        }
        public void setCommand(SqlCommand command)
        {
            this.command = command;
        }
        public void setAdapter(SqlDataAdapter adapter)
        {
            this.adapter = adapter;
        }
    }
}
