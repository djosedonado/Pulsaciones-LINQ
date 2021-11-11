using Entidad;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
    public class PersonaRepository
    {
        DbConnection _connection;


        public PersonaRepository(DbConnection connection)
        {
            _connection = connection;
        }
        string ruta = "Persona.txt";

        public void Guardar(Persona persona)
        {
            using (DbCommand command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Persona (identificacion, Nombre, Sexo,Edad,Pulsacion) values(@identificacion, @Nombre, @Sexo,@Edad,@Pulsacion) ";
                command.Parameters.Add(new SqlParameter("@identificacion", persona.Identificacion));
                command.Parameters.Add(new SqlParameter("@Nombre", persona.Nombre));
                command.Parameters.Add(new SqlParameter("@Sexo", persona.Sexo));
                command.Parameters.Add(new SqlParameter("@Edad", persona.Edad));
                command.Parameters.Add(new SqlParameter("@Pulsacion", persona.Pulsacion));
                int filas = command.ExecuteNonQuery();
            }


        }
        public List<Persona> Consultar()
        {
            List<Persona> personas = new List<Persona>();
            using (DbCommand command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from persona ";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Persona persona = MapearPersona(reader);
                        personas.Add(persona);
                    }

                }
                reader.Close();


            }

            return personas;
        }

        private static Persona MapearPersona(DbDataReader reader)
        {
            Persona persona = new Persona();
            persona.Identificacion = (string)reader["Identificacion"];
            persona.Nombre = (string)reader["Nombre"];
            persona.Sexo = (string)reader["sexo"];
            persona.Edad = (int)reader["Edad"];
            persona.Pulsacion = reader.GetDecimal(4);
            return persona;
        }


        public void Eliminar(string identificacion)
        {
            using (DbCommand command = _connection.CreateCommand())
            {
                command.CommandText = "delete from persona where identificacion=@identificacion ";
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                int filas = command.ExecuteNonQuery();
            }


        }

        public void Modificar(Persona personaNuevo, string identificacion)
        {
            using (DbCommand command = _connection.CreateCommand())
            {
                command.CommandText = "update persona set Nombre=@Nombre, Edad=@Edad,Sexo=@Sexo, pulsacion=@Pulsacion where Identificacion=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", personaNuevo.Identificacion));
                command.Parameters.Add(new SqlParameter("@Nombre", personaNuevo.Nombre));
                command.Parameters.Add(new SqlParameter("@Sexo", personaNuevo.Sexo));
                command.Parameters.Add(new SqlParameter("@Edad", personaNuevo.Edad));
                command.Parameters.Add(new SqlParameter("@Pulsacion", personaNuevo.Pulsacion));
                int filas = command.ExecuteNonQuery();
            }
        }

        public Persona BuscarPorIdentificacion(string identificacion)
        {

            Persona persona;
            using (DbCommand command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from persona where Identificacion=@identificacion ";
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        persona = MapearPersona(reader);
                        return persona;
                    }

                }
                reader.Close();
                return null;
            }
        }
        public List<Persona> FiltrarPorSexo(string sexo)
        {
            return (from p in Consultar()
                    where p.Sexo.Equals(sexo)
                    orderby p.Nombre ascending
                    select p).ToList();
        }

        public List<Persona> FiltrarPorSexoMetodo(string sexo)
        {
            return Consultar().Where(p => p.Sexo.Equals(sexo)).ToList();
        }

        public int Contar(string sexo)
        {
            return Consultar().Count(p => p.Sexo.Equals(sexo));
        }

        public double Promediar()
        {
            return Consultar().Average(p => p.Edad);
        }


        //public int Sumar()
        //{
        //    //return Convert.ToInt32(Consultar().Sum(p => p.Pulsacion));
        //}


        public List<Persona> FiltrarPorAnio(int year, int month)
        {
            return Consultar().Where(p => p.FechaNacimiento.Year == year && p.FechaNacimiento.Month == month).ToList();
        }


        public List<Persona> FiltrarPorPalabra(string palabra)
        {
            return (from p in Consultar()
                    where p.Nombre.ToLower().Contains(palabra.ToLower())
                    select p).ToList();
        }
        public List<Persona> FiltrarPorSexoVersionLarga(string sexo)
        {
            List<Persona> personasFiltradas = new List<Persona>();
            foreach (var item in Consultar())
            {
                if (item.Sexo.Equals(sexo))
                {
                    personasFiltradas.Add(item);
                }
            }
            return personasFiltradas;
        }

    }
}
