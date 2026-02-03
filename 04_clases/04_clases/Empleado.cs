using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_clases
{
    public class Empleado
    {
        //Campos privados: son variables usadas para alamxcenar los valores
        //reales de las propiedades. Siempre se declaran antes de las propiedades.
        //Por convencion en C# se nombran iniciando con guion bajo. (Underscore prefix)
        private int _edad;
        private char _genero;
        private float _salario;
        private char _contrato;

        //Propiedades
        //las propiedades que no escriben a campos privados solo llevan { get; set; }
        public string Nombre { get; set; }
        //Las propiedades que escriben a campos privados son publicas y
        //deben llevar algo conocido como validadores publicos
        public int Edad {
            get { return this._edad; } //retornar el valor guardado en el campo privado
            set
            {
                //evaluar el valor que se pretende almacenar en el campo privado
                if (value >= 18)
                    this._edad = value; //se acepta
                else
                    throw new ArgumentException("La edad debe ser >= 18");
                    //en caso de no cumplir con la regla se lanza una excepcion
            }
        }
        public char Genero { get; set; }
        public float Salario { get; set; }
        public char Contrato { get; set; }

        //Constructores
        public Empleado()
        {
            this.Nombre = "No definido";
            this.Edad = 18;
            this.Genero = 'X';
            this.Salario = 0.00f;
            this.Contrato = 'T';
        }
        public Empleado(string nombre, int edad, char genero, float salario, char contrato)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Salario = salario;
            this.Contrato = contrato;
        }

        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("------------ Perfil ------------");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.Genero}");
            Console.WriteLine($"Salario: {this.Salario}");
            Console.WriteLine($"Contrato: {this.Contrato}");
        }
    }
}
