using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame_2p.Controller
{
    class Persona
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;
        private int edad;
        private string correo;
        private DateTime fechaNacim;

        public Persona() { }

        public Persona(int id, string nombre, int edad, string correo, DateTime fechaNacim)
        {
            this.ID = id;
            this.nombre = nombre;
            this.edad = edad;
            this.correo = correo;
            this.fechaNacim = fechaNacim;
        }
        public DateTime FechaNacim
        {
            get { return fechaNacim; }
            set { fechaNacim = value; }
        }


        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }


        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
