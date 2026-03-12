using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_abstraccion1
{
    public class Gato : SerVivo
    {
        //Propiedades
        public string Apodo { get; set; }

        //Constructor
        public Gato(string Apodo) : base("Felino")
        {
            this.Apodo = Apodo;
        }

        //Metodos
        //Implementacion de los metodos abstractos
        public override void Dormir()
        {
            Console.WriteLine("Busca un rincon y se duerme.");
        }
        public override void Alimentarse()
        {
            Console.WriteLine("Come alimentos gatunos.");
        }
        //tambien puede usar funcion de flecha (solo 1 instruccion)
        public override void Hablar() => Console.WriteLine("Miau");
        public override void Desplazarse()
        {
            Console.WriteLine("Camina de forma sigilosa");
        }
    }
}
