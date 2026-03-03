using _13_herencia1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_herencia1
{
    public class Empleado : Persona
    {
        //Propiedades
        public float Salario { get; set; }
        public string Cargo { get; set; }

        //Constructores
        /*Si Usted desea que la clase hijo tenga un constructor
         sin parametros, a pesar que la clase padre exige
        por medio de un constructor con parametros; entonces lo
        que Usted debe hacer es construir la super clase con datos
        genericos.*/
        public Empleado() : base("No tiene",0,Enum.Genero.Otros)
        {
            this.Salario = 0;
            this.Cargo = "No definido";
        }
        //Tambien si gusta puede tener mas constructores en la
        //clase hijo
        public Empleado(string nombre, int edad, Genero genero,
            float salario, string cargo)
            : base(nombre, edad, genero)
        {
            this.Salario= salario;
            this.Cargo = cargo;
        }
        //en cualquier constructor de la clase hijo debe
        //ejecutar el constructor de la clase padre (base)

        public void Trabajar()
        {
            Console.WriteLine($"Mi cargo es {this.Cargo}");
            Console.WriteLine($"Mi edad es {this.Edad}");
        }
    }
}
