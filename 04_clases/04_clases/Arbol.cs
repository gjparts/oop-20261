using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_clases
{
    /*reemplazamos internal por public en la definicion
     de la clase para que esta sera accesible
    desde cualquier proyecto dentro de nuestra
    solucion.
    Para nombrar clases y miembros en C# se recomienda
    usar la notacion Pascal Case.*/
    public class Arbol
    {
        /*Propiedades
         Son las caracteristicas de la clase, la describen.*/
        public string Nombre { get; set; } //auto-implemented property
        public string Especie { get; set; }
        public float Altura { get; set; }
        public int Edad {  get; set; }
        /*Metodos
         Son las funciones dentro de la clase.*/
        public void Purificar()
        {
            Console.WriteLine("Soy un arbol y estoy purificando el oxigeno");
        }
    }
}
