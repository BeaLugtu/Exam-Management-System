using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Exam_Management_System
{
    class DBAccess
    {
        //private readonly string MySqlCon = "server=localhost; user= root ; database=examio; password= ";
        private readonly string MySqlCon = "server=26.96.197.206; user=admin; database=exam.io; password=admin";
        private readonly MySqlConnection mySqlConnection = new MySqlConnection();
        private readonly MySqlCommand command = new MySqlCommand();
        private readonly MySqlDataAdapter adapter = new MySqlDataAdapter();

        // Creates a database connection
        public void createConn()
        {
            try
            {
                if (mySqlConnection.State != ConnectionState.Open)
                {
                    mySqlConnection.ConnectionString = MySqlCon;
                    mySqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw;
            }
        }

        // Closes the existing database connection
        public void closeConn()
        {
            mySqlConnection.Close();
        }

        // Executes SQL commands (insert, update, delete) on a DataTable using a DataAdapter
        public int executeDataAdapter(DataTable tblName, string strSelectSql)
        {
            try
            {
                if (mySqlConnection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                adapter.SelectCommand = new MySqlCommand(strSelectSql, mySqlConnection);
                MySqlCommandBuilder DbCommandBuilder = new MySqlCommandBuilder(adapter);

                return adapter.Update(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Reads data from the database into a DataTable using a DataAdapter and a provided SQL query
        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (mySqlConnection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = mySqlConnection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter.SelectCommand = command;
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Reads data from the database using a DataReader and a provided SQL query
        public MySqlDataReader readDatathroughReader(string query)
        {
            // DataReader used to sequentially read data from a data source
            MySqlDataReader reader;

            try
            {
                if (mySqlConnection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = mySqlConnection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Executes a SQL command (insert, update, delete) using a provided MySqlCommand object
        public int executeQuery(MySqlCommand dbCommand)
        {
            try
            {
                if (mySqlConnection.State != ConnectionState.Open)
                {
                    createConn(); // Ensure connection is open
                }

                dbCommand.Connection = mySqlConnection; // Assign mySqlConnection
                dbCommand.CommandType = CommandType.Text;

                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw;
            }
        }

        // Executes a SQL command and returns the first column of the first row in the result set
        public object executeScalar(MySqlCommand dbCommand)
        {
            try
            {
                if (mySqlConnection.State != ConnectionState.Open)
                {
                    createConn(); // Ensure connection is open
                }

                dbCommand.Connection = mySqlConnection; // Assign mySqlConnection
                dbCommand.CommandType = CommandType.Text;

                return dbCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw;
            }
        }

    }

}
