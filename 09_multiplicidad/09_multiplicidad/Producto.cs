using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_asociacion_clases
{
    public class Producto
    {
        //Campos privados
        private CategoriaProducto _categoria;

        //Propiedades
        public string Nombre { get; set; }
        public CategoriaProducto Categoria
        {
            get => this._categoria;
            set
            {
                //asociacion por composicion
                if( value == null )
                    throw new ArgumentException( "Categoria en Producto no puede ser null" );
                else
                    this._categoria = value; //se acepta
            }
        }
        public float PrecioVenta { get; set; }

        //Constructor
        public Producto(string nombre, CategoriaProducto categoria, float precioVenta)
        {
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.PrecioVenta = precioVenta;
        }
    }
}
