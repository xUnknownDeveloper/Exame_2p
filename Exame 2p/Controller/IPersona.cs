using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_2p.Controller
{
    interface IPersona
    {
        List<Persona> ObtenerInfo();
        bool InsertarPersona(string nombre, int edad, string correo, DateTime fechaNacim);
        bool EliminarPersona(int ID);
        bool ActualizarPersona(int ID, string nombre, int edad, string correo, DateTime fechaNacim);
    }
}
