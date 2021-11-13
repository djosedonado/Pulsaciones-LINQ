using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
           //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PulsacionG01;Integrated Security=True";
           string connectionString = "Data Source=localhost:1521/xe; User Id = hr; Password = oracle";
           var connection= new OracleConnection(connectionString);
            connection.Open();

            Console.WriteLine(connection.State);
            connection.Close();
            Console.ReadKey();

        }
    }
}
