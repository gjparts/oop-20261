using _13_herencia1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_herencia1
{
    public class Persona
    {
        //Campos privados
        private int _edad;

        //Propiedades
        public string Nombre { get; set;  }
        public int Edad
        {
            get => this._edad;
            set
            {
                if (value >= 0)
                    this._edad = value;
                else
                    throw new ArgumentException("Edad debe ser >= 0");
            }
        }
        public Genero Genero { get; set; }

        //Constructor
        public Persona(string nombre, int edad, Genero genero)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
        }

        //Metodos
        public void Saludar()
        {
            Console.WriteLine($"Hola mi nombre es {this.Nombre}");
        }
    }
}
