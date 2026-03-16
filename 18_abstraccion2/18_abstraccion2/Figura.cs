using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_abstraccion2
{
    public abstract class Figura
    {
        //Propiedades
        public string Nombre { get; set; }

        //Constructor
        public Figura(string nombre)
        {
            this.Nombre= nombre;
        }

        //Metodos abstractos
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
