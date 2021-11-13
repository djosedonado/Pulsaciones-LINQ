using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using Entidad;
using System.Data.Common;

namespace PruebaGrupo03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string CadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PulsacionG01;Integrated Security=True";
            DbConnection connection = new SqlConnection(CadenaConexion);
            //OracleConnection connection = new OracleConnection(CadenaConexion);
            connection.Open();
            DbCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from persona";
            DbDataReader reader =command.ExecuteReader();
            List<Persona> personas = new List<Persona>();
            while (reader.Read())
            {
                Persona persona = new Persona();
                persona.Identificacion = reader.GetString(0);
                persona.Nombre = reader.GetString(1);
                persona.Sexo = reader["Sexo"].ToString();
                persona.Edad =reader.GetInt32(3);
                personas.Add(persona);
            }
            foreach (var item in personas)
            {
                Console.WriteLine($"{ item.Identificacion}");
            }
            Console.WriteLine(connection.State);
            connection.Close();
            Console.ReadKey();


        }
    }
}
