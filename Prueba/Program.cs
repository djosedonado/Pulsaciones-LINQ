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
            var command = connection.CreateCommand();
            command.CommandText = "Select * from Employees";
            var reader = command.ExecuteReader();
            List<Persona> personas = new List<Persona>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.Identificacion = (string)reader["Employees_Id"];
                    persona.Nombre = (string)reader["First_Name"];
                    personas.Add(persona);
                }
                reader.Close();
            }


            foreach (var item in personas)
            {
                Console.WriteLine($"{item.Identificacion}");
            }


            Console.WriteLine(connection.State);
            connection.Close();
            Console.ReadKey();

        }
    }
}
