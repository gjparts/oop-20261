using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_abstraccion2
{
    public class Circulo : Figura
    {
        //Propiedades
        public double Radio {  get; set; }

        //Constructor
        public Circulo(double radio) : base("Circulo")
        {
            this.Radio = radio;
        }

        //Metodos
        //Implementacion de metodos abstractos
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(this.Radio, 2);
        }
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * this.Radio;
        }
    }
}
