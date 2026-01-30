using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_clases
{
    public class Persona
    {
        //Propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }
        public string DNI { get; set; }

        /*Metodo constructor:
         es aquel que permite asignar memoria a un objeto
        que se crea a partir de una clase.
        -> Si Usted no define ningun constructor a la clase;
           entonces C# va a crear un constructor automaticamente
           sin parametros.
        
        Caracteristicas de un constructor:
        1) Son publicos (en C#, JAVA y C++)
        2) En C# se deben de nombrar igual que a la clase que pertenecen
        3) No tienen ningun tipo de dato definido puesto que
           retornan una instancia de la clase.
        4) En C# una clase puede tener uno o varios constructores
           siempre y cuando tengan diferente firma.
        5) Normalmente los constructores se usan para inicializar
           valores en las propiedades de la clase; pero tambien
           se pueden usar para otras acciones, por ejemplo conexion
           a una base de datos, registrar algo en bitacora, etc.*/
        
        //Constructores
        public Persona()
        {
            //Constructor sin parametros
            this.Nombre = "No tiene";
            this.Edad = 0;
            this.Genero = 'X';
            this.DNI = "No determinado";
        }
        public Persona(string nombre, int edad, char genero, string dni)
        {
            //Constructor con todos los parametros (4 Propiedades - 4 parametros)
            //para nombrar los parametros de un metodo se recomienda usar
            //en C# las notaciones camel Case o snake_case
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.DNI = dni;
        }
        public Persona(string nombre, int edad)
        {
            //constructor con dos parametros
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = 'X';
            this.DNI = "No determinado";
        }
        //Metodos: son funciones declaradas dentro de una clase
        public void Imprimir()
        {
            Console.WriteLine("*********** Perfil de la Persona ***********");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"DNI: {this.DNI}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.GeneroDescripcion()}");
        }
        public bool EsMayorDeEdad()
        {
            if (this.Edad >= 18)
                return true;
            else
                return false;
        }
        
        //public bool EsMayorDeEdad() => this.Edad >= 18;

        /*
         public bool EsMayorDeEdad()
        {
            return this.Edad >= 18;
        }
         */
        public string GeneroDescripcion()
        {
            if (this.Genero == 'M') return "Masculino";
            if (this.Genero == 'F') return "Femenino";
            if (this.Genero == 'X') return "Otros";
            //si llego aqui es porque no se cumplio ninguna condicion de arriba
            return "No configurado";
        }
    }
}
