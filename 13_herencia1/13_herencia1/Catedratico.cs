using _13_herencia1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_herencia1
{
    public class Catedratico : Empleado
    {
        //Propiedades
        public string Profesion {  get; set; }

        //Constructor
        public Catedratico(string nombre, int edad, Genero genero,
            float salario, String profesion)
            : base(nombre, edad, genero, salario, "Docente/Catedratico")
        {
            this.Profesion = profesion;
        }

        //Metodos
        public void Educar()
        {
            Console.WriteLine($"Me gradue de {this.Profesion}");
        }
    }
}
