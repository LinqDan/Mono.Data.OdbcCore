using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.Odbc;

namespace TestOdbcCore
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Start.");

            Console.WriteLine("create OdbcConnection object...");
            using (var connection = new OdbcConnection("DSN=SQL16"))
            {
                Console.WriteLine("Open connection...");
                connection.Open();

                Console.WriteLine("Create command...");
                using (var command = connection.CreateCommand())
                {

                    command.CommandText = "select TABLE_NAME from INFORMATION_SCHEMA.TABLES";

                    Console.WriteLine("Execute reader...");
                    using (var reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Tables:");

                        while (reader.Read())
                        {
                            string tableName = reader.GetString(reader.GetOrdinal("TABLE_NAME"));
                            Console.WriteLine(tableName);
                        };
                    }
                }

                Console.WriteLine("Done.");

            }
        }
    }
}
