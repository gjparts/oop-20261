using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_asociacion_clases
{
    public class Estudiante
    {
        //Campos privados
        private int _edad;
        private Direccion _direccion;

        //Propiedades
        public string Cuenta { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int Edad
        {
            get => this._edad;
            set
            {
                if (value >= 0)
                    this._edad = value; //se acepta
                else
                    throw new ArgumentException("Edad debe de ser >= 0");
            }
        }
        public Direccion Direccion
        {
            get => this._direccion;
            set
            {
                //asociacion por composicion
                if( value == null )
                    throw new ArgumentException("Direccion en Estudiante no puede ser null");
                else
                    this._direccion = value; //se acepta
            }
        }
        public Cargo Trabajo { get; set; } //asociacion por agregacion (no es obligatorio)

        //Constructor
        public Estudiante(string cuenta, string nombre, string carrera, int edad, Direccion direccion, Cargo trabajo)
        {
            this.Cuenta = cuenta;
            this.Nombre = nombre;
            this.Carrera = carrera;
            this.Edad = edad;
            this.Direccion = direccion;
            this.Trabajo = trabajo;
        }
        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("-------------- Perfil del Estudiante --------------");
            Console.WriteLine($"Cuenta: {this.Cuenta}");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Carrera: {this.Carrera}");
            Console.WriteLine($"Edad: {this.Edad}");
            
            Console.WriteLine($"Direccion:");
            Console.WriteLine($"\tBarrio: {this.Direccion.Barrio.Nombre}"); //no olvide la cascada
            Console.WriteLine($"\tCalle: {this.Direccion.Calle}");
            Console.WriteLine($"\tAvenida: {this.Direccion.Avenida}");
            Console.WriteLine($"\tCasa: {this.Direccion.Casa}");
            Console.WriteLine($"\tCiudad: {this.Direccion.Barrio.Ciudad}");
            Console.WriteLine($"\tMunicipio: {this.Direccion.Barrio.Municipio}");
            Console.WriteLine($"\tPais: {this.Direccion.Barrio.Pais}");

            //Trabajo puede llegar a ser null ya que se asocia por agregacion
            //por lo tanto si es null no lo imprimimos.
            if(this.Trabajo != null)
            {
                Console.WriteLine("Informacion laboral:");
                Console.WriteLine($"\tEmpresa: {this.Trabajo.Empresa.Nombre}");
                Console.WriteLine($"\tCargo: {this.Trabajo.Descripcion}");
                Console.WriteLine($"\tCiudad: {this.Trabajo.Empresa.Direccion.Barrio.Ciudad}");
                Console.WriteLine($"\tPais: {this.Trabajo.Empresa.Direccion.Barrio.Pais}");
            }
        }
    }
}
