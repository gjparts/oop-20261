using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_abstraccion1
{
    public class Humano : SerVivo
    {
        //Propiedades
        public string Nombre { get; set; }

        //Constructor
        public Humano(string nombre) : base("Homo Sapiens")
        {
            this.Nombre = nombre;
        }

        //Metodos
        //Implementacion de metodos abstractos
        public override void Alimentarse()
        {
            Console.WriteLine("Come de todo");
        }
        public override void Hablar()
        {
            Console.WriteLine("Hola");
        }
        public override void Desplazarse()
        {
            Console.WriteLine("Camina de forma bipeda");
        }
        public override void Dormir()
        {
            Console.WriteLine("Busca un lugar seguro y descansa");
        }
    }
}
