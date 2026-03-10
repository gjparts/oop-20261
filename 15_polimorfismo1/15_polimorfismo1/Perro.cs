using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_polimorfismo1
{
    public class Perro : Animal
    {
        //Propiedades
        public string Apodo { get; set; }
        public string Raza { get; set; }

        //Constructor
        public Perro(string apodo, string raza, bool tieneCola)
            :base("Perro","Canino",4,tieneCola)
        {
            this.Apodo = apodo;
            this.Raza = raza;
        }

        //Metodos
        public void Jugar()
        {
            Console.WriteLine("El perro juega.");
        }
        public override void Hablar()
        {
            //override total
            Console.WriteLine("Wua Woof Bark");
        }
        public override void Imprimir()
        {
            //override parcial
            base.Imprimir();
            Console.WriteLine($"Apodo: {this.Apodo}");
            Console.WriteLine($"Raza: {this.Raza}");
        }
    }
}
