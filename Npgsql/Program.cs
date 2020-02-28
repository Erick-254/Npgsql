using System;
using Npgsql;

namespace Npgsql
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify connection options and open an connection
            NpgsqlConnection conn = new NpgsqlConnection (" Server= 127.0.0.1; User Id = postgres;Password = pwd; Database=rental;");
            conn.Open();

            // Define a query
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT title FROM movies ", conn);

            // Execute a query
            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dataReader.Read())
                Console.Write($" title: { dataReader[0] } \n");

            // Close connection
            conn.Close();
        }
    }
}
             
