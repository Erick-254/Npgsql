using System;
using Npgsql;

class Program
{
    static void Main(string[] agrs)
    {
        // S p e c i f y c onnec t i on o p t i o n s and open an c onnec t i on
        NpgsqlConnection conn = new NpgsqlConnection(" Server = 127.0.0.1 ; UserId = postgres; Password = pwd; Database = rental;");

        conn.Open();
        // De f ine a quer y
        NpgsqlCommand cmd = new NpgsqlCommand("SELECT title FROM movies ", conn);

        // Execu te a quer y
        NpgsqlDataReader dataReader = cmd.ExecuteReader();
        // Read a l l rows and o u t p u t t h e f i r s t column in each row
        while (dataReader.Read())

            // Execu te a quer y NpgsqlDataReader dataReader = cmd.ExecuteReader();
            // Read a l l rows and o u t p u t t h e f i r s t column in each row while (dataReader.Read ( ) )
            Console.Write($"title: { dataReader[0] } \n");
        // Cl o se c onnec t i on
        dataReader.Close();
        NpgsqlCommand cmd2 = new NpgsqlCommand("Select title, year FROM movie", conn);
        using(NpgsqlDataReader dataReader2= cmd2.ExecuteReader())
        {

        }
    }
}
