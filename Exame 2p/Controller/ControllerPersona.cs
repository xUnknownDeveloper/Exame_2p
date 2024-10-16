using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exame_2p.Models.DsPersonasTableAdapters;
using System.Data;

namespace Exame_2p.Controller
{
    class ControllerPersona : IPersona
    {
        List<Persona> listaPersonas = new List<Persona>();
        Persona p = new Persona();
        public bool ActualizarPersona(int ID, string nombre, int edad, string correo, DateTime fechaNacim)
        {
            try
            {
                using (personasTableAdapter persona = new personasTableAdapter())
                {
                    if (!(nombre == null && correo == null && fechaNacim == null))
                    {
                        persona.actualizarPersona(nombre, edad, fechaNacim, correo, ID);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool EliminarPersona(int ID)
        {
            try
            {
                using (personasTableAdapter persona = new personasTableAdapter())
                {
                    persona.eliminarPersona(ID);
                    return true;
                }
            }
            catch (Exception) 
            {
                return false;
            }
        }
        public bool InsertarPersona(string nombre, int edad, string correo, DateTime fechaNacim)
        {
            try
            {
                using (personasTableAdapter persona = new personasTableAdapter())
                {
                    if (!(nombre == null && correo == null && fechaNacim == null)) 
                    {
                        persona.insertarPersonar(nombre, edad, fechaNacim, correo);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Persona> ObtenerInfo()
        {
            try
            {
                using (personasTableAdapter persona = new personasTableAdapter())
                {
                    var data = persona.GetData();
                    foreach (DataRow row in data)
                    {
                        p.ID = Convert.ToInt32(row["ID"]);
                        p.Nombre = row["Nombre"].ToString();
                        p.Edad = Convert.ToInt32(row["Edad"]);                       
                        p.FechaNacim = Convert.ToDateTime(row["FechaNacimiento"]);
                        p.Correo = row["CorreoElectronico"].ToString();

                        listaPersonas.Add(new Persona(p.ID,p.Nombre, p.Edad, p.Correo, p.FechaNacim));
                    }
                }
                return listaPersonas;
            }
            catch (Exception)
            {
                return listaPersonas;
            }

        }
    }
}
