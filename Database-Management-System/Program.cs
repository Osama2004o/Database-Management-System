using System;
using System.Data.SqlClient;
using System.Text;

namespace ApplicationToDatabase
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string connString = "Server= localhost; Database= FCI; Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connString);

        }
    }
}