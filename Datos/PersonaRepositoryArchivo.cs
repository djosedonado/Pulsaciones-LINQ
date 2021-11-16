﻿using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace Datos
{
    public class PersonaRepositoryArchivo
    {
    
        public PersonaRepositoryArchivo()
        {
           
        }
        string ruta = "Persona.txt";

        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine(persona.Escribir());
            escritor.Close();
            file.Close();
        }
        public List<Persona> Consultar()
        {
            List<Persona> personas = new List<Persona>();
            
            return personas;
        }

        private static Persona MapearPersona(string linea)
        {
            string[] datosPersona = linea.Split(';');
            Persona persona = new Persona();
            persona.Identificacion = datosPersona[0];
            persona.Nombre = datosPersona[1];
            persona.Sexo = datosPersona[2];
            persona.Edad = Int32.Parse(datosPersona[3]);
            persona.Pulsacion = Convert.ToDecimal(datosPersona[4]);
            return persona;
        }

        public void Eliminar(string identificacion)
        {
            List<Persona> personas = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in personas)
            {
                if (!item.Identificacion.Equals(identificacion))
                {
                    Guardar(item);
                }
            }


        }

        public void Modificar(Persona personaNuevo, string identificacion)
        {
            List<Persona> personas = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in personas)
            {
                if (!item.Identificacion.Equals(identificacion))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(personaNuevo);
                }
            }
        }

        public Persona BuscarPorIdentificacion(string identificacion)
        {

            foreach (var item in Consultar())
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
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
            return Consultar().Where(p=>p.Sexo.Equals(sexo)).ToList();
        }

        public int Contar (string sexo)
        {
            return Consultar().Count(p=>p.Sexo.Equals(sexo));
        }

        public double Promediar()
        {
            return Consultar().Average(p => p.Edad);
        }


        public int Sumar()
        {
            return Convert.ToInt32(Consultar().Sum(p=>p.Pulsacion));
        }


        public List<Persona> FiltrarPorAnio(int year, int month)
        {
            return Consultar().Where(p=>p.FechaNacimiento.Year==year && p.FechaNacimiento.Month== month).ToList();
        }


        public List<Persona> FiltrarPorPalabra(string palabra)
        {
            return (from p in Consultar()
                    where p.Nombre.ToLower().Contains(palabra.ToLower())
                    select p).ToList();
        }
        public List<Persona> FiltrarPorSexoVersionLarga (string sexo)
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
