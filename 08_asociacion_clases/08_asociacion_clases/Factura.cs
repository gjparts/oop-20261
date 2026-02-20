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
        private Producto _producto1;

        //Propiedades
        public int Numero {  get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Producto Producto1
        {
            get => this._producto1;
            set
            {
                //relacion por composicion
                if( value == null )
                    throw new ArgumentException( "Producto1 en Factura no puede ser null" );
                else
                    this._producto1 = value; //se acepta
            }
        }
        //Productos del 2 al 4 no son obligatorios
        public Producto Producto2 { get; set; }
        public Producto Producto3 { get; set; }
        public Producto Producto4 { get; set; }

        //Constructor
        public Factura(int numero, DateTime fecha, Cliente cliente, Producto producto1)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.Producto1 = producto1;
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
            //Producto 1 es obligatorio (jamas vendra nulll)
            Console.WriteLine($"{this.Producto1.Nombre}\t{this.Producto1.PrecioVenta}");
            suma += this.Producto1.PrecioVenta;

            //Productos 2 al 4 pueden llegar a ser null de ser asi se ignoran
            if( this.Producto2 != null)
            {
                Console.WriteLine($"{this.Producto2.Nombre}\t{this.Producto2.PrecioVenta}");
                suma += this.Producto2.PrecioVenta;
            }
            if (this.Producto3 != null)
            {
                Console.WriteLine($"{this.Producto3.Nombre}\t{this.Producto3.PrecioVenta}");
                suma += this.Producto3.PrecioVenta;
            }
            if (this.Producto4 != null)
            {
                Console.WriteLine($"{this.Producto4.Nombre}\t{this.Producto4.PrecioVenta}");
                suma += this.Producto4.PrecioVenta;
            }

            //Resultados a dos decimales
            Console.WriteLine($"Subtotal: {Math.Round(suma,2)}");
            Console.WriteLine($"ISV 15%: {Math.Round(suma*0.15, 2)}");
            Console.WriteLine($"Total: {Math.Round(suma*1.15, 2)}");
        }
    }
}
