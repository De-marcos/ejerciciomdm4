using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciomdm
{
    internal class mamifero
    {
        private string nombre { get; set; }
        protected double peso { get; set; }

        //Constructor
        public mamifero(string n, double p)
        {
            this.nombre = n;
            this.peso = p;
        }

        //Metodos
        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getNombre()
        {
            return nombre;
        }
    }
}
