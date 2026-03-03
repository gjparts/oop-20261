using _13_herencia1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_herencia1
{
    public class Estudiante : Persona //Herencia
    {
        //Propiedades
        public string Cuenta { get; set; }
        public string Carrera { get; set; }

        //Constructor
        /*Observe que al construir la clase hijo
         se debe construir la super clase (base)*/
        public Estudiante(string nombre, int edad,
            Genero genero, string cuenta, string carrera)
            : base(nombre, edad, genero)
        {
            //inicializar las propiedades de la clase hijo
            this.Cuenta = cuenta;
            this.Carrera = carrera;
        }
        //Nombre, Edad y Genero se inicializan en la clase padre
        //Cuenta y Carrera se inicializan en la clase hijo
        public void Estudiar()
        {
            Console.WriteLine($"Estudio la carrera de {this.Carrera}");
            Console.WriteLine($"Mi edad es {this.Edad}");
        }
    }
}
