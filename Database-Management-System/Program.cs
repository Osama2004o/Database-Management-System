using System;
using System.Data.SqlClient;

namespace ApplicationToDatabase
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string connString = "Server= localhost; Database= FCI; Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connString);
            try
            {
                // Open connection
                conn.Open();

                Console.WriteLine("Connection Successful...");

                string sqlQueryInsert = "INSERT INTO FCI.dbo.Employee VALUES " +
                                        "(@name, @birthdate, @gender, @city, @isMarried)";

                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);

                
                Console.WriteLine("Executing Query...");
                command.ExecuteNonQuery(); // Execute the Query

                conn.Close();
                Console.WriteLine("Inserted Successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
