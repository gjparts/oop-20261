using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_polimorfismo1
{
    public class Gato : Animal
    {
        //Propiedades
        public string Apodo { get; set; }
        public bool TienePelaje { get; set; }

        //Constructor
        public Gato(string apodo, bool tienePelaje, bool tieneCola)
            : base("Gato","Felino",4, tieneCola)
        {
            this.Apodo = apodo;
            this.TienePelaje = tienePelaje;
        }

        //Metodos
        public void Ronronear()
        {
            Console.WriteLine("Prrrrrrr");
        }
        //Polimorfismo: cambiar la respuesta para un metodo heredado
        //se usa la clausula override en la clase hijo.
        //Para poder hacer override el metodo debe haber sido declarado
        //como virtual en la clase padre.
        public override void Hablar()
        {
            //Override completo: cambia la respuesta de todo el metodo heredado
            Console.WriteLine("Miau");
        }
        public override void Imprimir()
        {
            //Override parcial: reutiliza codigo del metodo heredado para
            //expandir su funcionalidad
            base.Imprimir(); //mandar a llamar el metodo heredado de la clase padre
            //agregamos el codigo adicional:
            Console.WriteLine($"Apodo: {this.Apodo}");
            Console.WriteLine($"Tiene pelaje: { (this.TienePelaje ? "Si" : "No" ) }");
        }
    }
}
