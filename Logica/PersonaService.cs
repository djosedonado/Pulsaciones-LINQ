using Datos;
using Entidad;
using System;
using System.Collections.Generic;
namespace Logica
{
    public class PersonaService

    {
        PersonaRepository personaRepository;
        ConnectionManager connectionManager; 
        public PersonaService(string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            personaRepository = new PersonaRepository(connectionManager.Connection);
        }
        public string Guardar(Persona persona)
        {


            try
            {
                connectionManager.Open();
                if (personaRepository.BuscarPorIdentificacion(persona.Identificacion) == null)
                {
                    personaRepository.Guardar(persona);
                    return "Datos Guardados Satisfactoriamente";
                }
                return $"La Persona con la Identificacion {persona.Identificacion} ya se encuentra registrada";

            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error:" + exception.Message;
            }finally
            {
                connectionManager.Close();
            }
   





        }
        public ConsultaResponse Consultar()
        {
            try
            {
                connectionManager.Open();
                return new ConsultaResponse(personaRepository.Consultar());
            }
            catch (Exception exception)
            {
                return new ConsultaResponse("Se presentó el siguiente error:" + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }

        }

        public string Eliminar(string identificacion)
        {

            try
            {
                connectionManager.Open();
                if (personaRepository.BuscarPorIdentificacion(identificacion) != null)
                {
                    personaRepository.Eliminar(identificacion);
                    return $"Se eliminó a la Persona con idnetificacion {identificacion}";
                }
                return $"No se encontró a la persona con Identificacion {identificacion}";
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error:" + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public string Modificar(Persona personaNueva, string identificacion)
        {

            try
            {
                connectionManager.Open();

                if (personaRepository.BuscarPorIdentificacion(identificacion) != null)
                {
                    personaRepository.Modificar(personaNueva, identificacion);
                    return $"Se Modificó a la Persona con idnetificacion {identificacion}";
                }
                return $"No se encontró a la persona con Identificacion {identificacion}";
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error:" + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }


        }
        public BusquedaReponse Buscar(string identificacion)
        {
            try
            {
                connectionManager.Open();

                return new BusquedaReponse(personaRepository.BuscarPorIdentificacion(identificacion));
            }
            catch (Exception exception)
            {
                return new BusquedaReponse("Se presentó el siguiente error:" + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }

        }

        public ConsultaResponse ConsultarPorSexo(string sexo)
        {
            try
            {
                connectionManager.Open();
                return new ConsultaResponse(personaRepository.FiltrarPorSexo(sexo));
            }
            catch (Exception exception)
            {
                return new ConsultaResponse("Se presentó el siguiente error:" + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }

        }

        public ConsultaResponse ConsultarPorPalabra(string palabra)
        {
            try
            {
                connectionManager.Open();
                return new ConsultaResponse(personaRepository.FiltrarPorPalabra(palabra));
            }
            catch (Exception exception)
            {
                return new ConsultaResponse("Se presentó el siguiente error:" + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }

        }




    }
    public class ConsultaResponse
    {
        public List<Persona> Personas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaResponse(List<Persona> personas)
        {
            Personas = personas;
            Error = false;
        }

        public ConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }

    public class BusquedaReponse
    {
        public Persona Persona { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public BusquedaReponse(Persona persona)
        {
            Persona = persona;
            Error = false;
        }

        public BusquedaReponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }

    public class PersonaDTO
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }

    }

}


