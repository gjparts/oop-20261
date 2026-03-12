using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_abstraccion1
{
    public abstract class SerVivo //clase abstracta
    {
        //Propiedades
        public string Especie {  get; set; }

        //Constructor
        public SerVivo(string especie)
        {
            this.Especie = especie;
        }

        //Metodos
        //Metodos abstractos (prototipos de funcion, solo firma)
        public abstract void Hablar();
        public abstract void Desplazarse();
        public abstract void Alimentarse();
        public abstract void Dormir();

        //Metodos concretos (aquellos que no son abstractos)
        public void Vivir()
        {
            //para este ejemplo el metodo Vivir depende
            //de los metodos abstractos
            this.Hablar();
            this.Desplazarse();
            this.Alimentarse();
            this.Dormir();
        }
    }
}
