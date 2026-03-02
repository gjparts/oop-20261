using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_multiplicidad
{
    public class Persona
    {
        //Propiedades
        public string Identidad { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public Direccion Direccion { get; set; } //asoc. por agregacion
        public Empresa EmpresaLabora { get; set; } //asoc. por agregacion
        public Mascota[] Mascotas { get; set; } //asoc. por agregacion (multiplicidad)
        public List<Diploma> Diplomas { get; set; } //asoc. por agregac, multiplicidad
        public Persona Conyuge { get; set; } //asoc. por agreg. ref. circular
        public List<Persona> Hijos { get; set; } //asoc. por agr., ref circ., multip.


        //Constructor
        public Persona(string identidad, string nombre, string telefono)
        {
            this.Identidad = identidad;
            this.Nombre = nombre;
            this.Telefono = telefono;
        }

        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("*********** Perfil ***********");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Identidad: {this.Identidad}");
            Console.WriteLine($"Telefono: {this.Telefono}");
            
            //relacion por agregacion con Direccion
            if( this.Direccion != null)
            {
                Console.WriteLine($"Direccion:");
                Console.WriteLine($"\tBarrio o colonia: {this.Direccion.Colonia.Nombre}");
                Console.WriteLine($"\tCalle: {this.Direccion.Calle}");
                Console.WriteLine($"\tAvenida: {this.Direccion.Avenida}");
                Console.WriteLine($"\tCasa: {this.Direccion.Casa}");
            }

            //relacion por agregacion con Empresa
            if( this.EmpresaLabora != null)
            {
                Console.WriteLine("Empresa donde trabaja:");
                Console.WriteLine($"\tNombre: {this.EmpresaLabora.Nombre}");
                Console.WriteLine($"\tTelefono: {this.EmpresaLabora.Telefono}");
                Console.WriteLine($"\tBarrio o colonia: {this.EmpresaLabora.Direccion.Colonia.Nombre}");
            }

            //relacion por agregacion con Mascota
            if( this.Mascotas != null)
            {
                Console.WriteLine("Mascotas:");
                foreach(Mascota item in this.Mascotas)
                {
                    if( item != null )
                        Console.WriteLine($"\t*{item.Nombre} ({item.Especie})");
                }
            }

            //relacion por agregacion con Diploma, coleccion de diplomas puede venir null
            if( this.Diplomas != null)
            {
                Console.WriteLine("Diplomas:");
                foreach(Diploma item in this.Diplomas)
                {
                    if (item != null) //validar cada diploma que no sea null
                        Console.WriteLine($"\t*{item.Nombre} ({item.Institucion})");
                }
            }

            //relacion por agregacion, Conyuge puede venir null
            if( this.Conyuge != null)
            {
                Console.WriteLine("Conyuge: ");
                Console.WriteLine($"\tNombre: {this.Conyuge.Nombre}");
                Console.WriteLine($"\tTelefono: {this.Conyuge.Telefono}");
            }

            //relacion por agregacion con Persona, coleccion de Hijos puede venir null
            if( this.Hijos != null)
            {
                Console.WriteLine("Hijos: ");
                foreach(Persona item in this.Hijos)
                {
                    if( item != null ) //validar cada hijo que no sea null
                        Console.WriteLine($"\t*{item.Nombre}");
                }
            }
        }
    }
}
