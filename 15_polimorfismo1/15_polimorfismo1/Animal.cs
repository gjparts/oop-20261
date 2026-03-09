using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_polimorfismo1
{
    public class Animal
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int Patas { get; set; }
        public Boolean TieneCola { get; set; }

        //Constructor
        public Animal(string nombre, string especie, int patas, bool tieneCola)
        {
            this.Nombre = nombre;
            this.Especie = especie;
            this.Patas = patas;
            this.TieneCola = tieneCola;
        }

        //Metodos
        //En C# para que un metodo soporte polimorfismo se la antepone
        //la clausula virtual:
        public virtual void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------ Animal ------");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Especie: {this.Especie}");
            Console.WriteLine($"Patas: {this.Patas}");
            Console.WriteLine($"TieneCola: { ( this.TieneCola ? "Si" : "No" ) }");
            Console.ResetColor();
        }
        public virtual void Hablar()
        {
            Console.WriteLine($"{this.Nombre} se esta comunicando.");
        }
    }
}
