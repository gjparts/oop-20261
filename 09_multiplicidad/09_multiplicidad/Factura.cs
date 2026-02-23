using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_asociacion_clases
{
    public class Factura
    {
        //Campos privados
        private Producto[] _productos; //arreglo de elementos de clase Producto

        //Propiedades
        public int Numero {  get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Producto[] Productos
        {
            get => this._productos;
            set
            {
                //el arreglo no puede ser null
                if (value == null)
                    throw new ArgumentException("Productos en Factura no puede ser null");
                else
                {
                    //el arreglo debe de tener al menos un item
                    if (value.Length == 0)
                        throw new ArgumentException("Productos debe tener al menos un item");
                    else
                    {
                        //el item 0 no puede ser null
                        if (value[0] == null)
                            throw new ArgumentException("Item 0 en Productos no puede ser null");
                        else
                            this._productos = value; //se acepta
                    }
                }
            }
        }

        //Constructor
        public Factura(int numero, DateTime fecha, Cliente cliente, Producto[] productos)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.Productos = productos;
        }

        //Imprimir
        public void Imprimir()
        {
            Console.WriteLine("*** Factura ***");
            Console.WriteLine($"Numero: {this.Numero}");
            //fecha en formato yyyy/MM/dd
            Console.WriteLine($"Fecha: {this.Fecha.ToString("yyyy/MM/dd")}");

            //si el cliente es null imprima Consumidor final
            //de lo contrario imprima el nombre y rtn del cliente
            if( this.Cliente == null )
                Console.WriteLine("Cliente: Consumidor final");
            else
            {
                Console.WriteLine($"Cliente: {this.Cliente.Nombre}");
                Console.WriteLine($"RTN: {this.Cliente.Rtn}");
            }

            //tabla de productos
            float suma = 0;
            Console.WriteLine("producto\tprecio");
            //recorrer cada item de la coleccion Productos
            foreach(Producto item in this.Productos)
            {
                //ignorar cualquier item que sea null
                if( item != null)
                {
                    Console.WriteLine($"{item.Nombre}\t{item.PrecioVenta}");
                    suma += item.PrecioVenta;
                }
            }

            //Resultados a dos decimales
            Console.WriteLine($"Subtotal: {Math.Round(suma,2)}");
            Console.WriteLine($"ISV 15%: {Math.Round(suma*0.15, 2)}");
            Console.WriteLine($"Total: {Math.Round(suma*1.15, 2)}");
        }
    }
}
