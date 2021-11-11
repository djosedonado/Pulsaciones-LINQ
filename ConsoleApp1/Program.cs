using System;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using Entidad;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Grupo02;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from persona";
            SqlDataReader reader= command.ExecuteReader();
            List<Persona> personas = new List<Persona>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.Identificacion = reader.GetString(1);
                    persona.Nombre = reader.GetString(2);
                    persona.Sexo = reader.GetString(3);
                    persona.Edad = reader.GetInt32(4);
                    personas.Add(persona);
                }
            }

            //foreach (var item in personas)
            //{
            //    Console.WriteLine($"{ item.Identificacion}");
            //}
            Console.WriteLine(personas.Select(i => i.ToString()).ToList());
            Console.WriteLine(connection.State);
            connection.Close();
            Console.ReadKey();
            
        }
    }
}
