using _13_herencia1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace _13_herencia1
{
    public class Practicante : Empleado
    {
        //Propiedades
        public int Meses { get; set; }

        //Constructor
        public Practicante(string nombre, int edad, Genero genero, int meses)
            : base(nombre,edad,genero,0,"Practicante/Pasante")
        {
            //Note que a la clase padre (Empleado) enviamos el salario en 0 y el cargo
            //como Practicante/Pasante para indicar que cualquier objeto de esta clase
            //siempre llevara esos valores de dicha forma.
            this.Meses = meses;
        }
    }
}
