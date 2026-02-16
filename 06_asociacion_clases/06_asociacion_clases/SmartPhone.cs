using _06_asociacion_clases.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_asociacion_clases
{
    public class SmartPhone
    {
        //Campos privados
        private Fabricante _marca;
        private string _modelo;
        private Bateria _bateria;

        //Propiedades
        public Fabricante Marca
        {
            get => this._marca;
            set
            {
                //relacion por composicion
                if (value == null)
                    throw new ArgumentException("Merca en SmartPhone no puede ser null");
                else
                    this._marca = value; //se acepta
            }
        }
        public String Modelo
        {
            get => this._modelo;
            set
            {
                if (value.Trim().Length == 0)
                    throw new ArgumentException("Modelo en SmartPhone no puede ir en blanco");
                else
                    this._modelo = value; //se acepta
            }
        }
        public Capacidad Almacenamiento { get; set; }
        public Capacidad Ram { get; set; }
        public Bateria Bateria
        {
            get => this._bateria;
            set
            {
                //asociacion por composicion
                if (value == null)
                    throw new ArgumentException("Bateria en SmartPhone no puede ser null");
                else
                    this._bateria = value; //se acepta
            }
        }
        //Chip y SmartPhone tienen una relacion por agregacion, por lo tanto
        //Chip1 y Chip2 no son obligatorios por lo tanto pueden llevar null si se desea
        public Chip Chip1 { get; set; }
        public Chip Chip2 { get; set; }

        //Constructor
        public SmartPhone(Fabricante marca, string modelo, Capacidad almacenamiento,
            Capacidad ram, Bateria bateria, Chip chip1, Chip chip2)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Almacenamiento = almacenamiento;
            this.Ram = ram;
            this.Bateria = bateria;
            this.Chip1 = chip1;
            this.Chip2 = chip2;
        }

        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("************* Ficha de SmartPhone *************");
            Console.WriteLine($"Fabricante: {this.Marca.Nombre}"); //referencia en cascada
            Console.WriteLine($"Modelo: {this.Modelo}");

            //Note que para imprimir el valor numerico de la enumeracion en lugar
            //de la etiqueta pusimos la conversion explicita (int) para indicar que
            //del valor de la lista enumerable tome el valor int en lugar del String de la
            //etiqueta (c4GB su valor int es 4) vea la enumeracion en el diagrama..
            Console.WriteLine($"Almacenamiento: {(int)this.Almacenamiento} GB");
            Console.WriteLine($"RAM: {(int)this.Ram} GB");

            Console.WriteLine("Datos de la bateria: ");
            Console.WriteLine($"\tMarca: {this.Bateria.Marca.Nombre}"); //no olviden la cascada
            Console.WriteLine($"\tMiliamperios: {this.Bateria.MiliAmperios}");

            /*Como la relacion con Chip es por agregacion existe la posibilidad
             de que Chip1 o Chip2 puedan no tener asignado un objeto por lo tanto
            su valor puede llegar a ser null.*/
            if( this.Chip1 != null)
            {
                //solo imprimimos Chip1 si fuera distinto de null
                Console.WriteLine("Chip 1:");
                Console.WriteLine($"\tOperador: {this.Chip1.Proveedor.Nombre}");
                Console.WriteLine($"\tNumero telefonico: {this.Chip1.NumeroTelefonico}");
            }
            if (this.Chip2 != null)
            {
                //solo imprimimos Chip2 si fuera distinto de null
                Console.WriteLine("Chip 2:");
                Console.WriteLine($"\tOperador: {this.Chip2.Proveedor.Nombre}");
                Console.WriteLine($"\tNumero telefonico: {this.Chip2.NumeroTelefonico}");
            }
        }
    }
}
