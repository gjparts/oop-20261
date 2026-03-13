using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_abstraccion1
{
    public abstract class SerVivo //clase abstracta
    {
        //Propiedades
        public string Especie {  get; set; }

        //Constructor
        public SerVivo(string especie)
        {
            this.Especie = especie;
        }

        //Metodos
        //Metodos abstractos (prototipos de funcion, solo firma)
        public abstract void Hablar();
        public abstract void Desplazarse();
        public abstract void Alimentarse();
        public abstract void Dormir();

        //Metodos concretos (aquellos que no son abstractos)
        public void Vivir()
        {
            //para este ejemplo el metodo Vivir depende
            //de los metodos abstractos
            this.Hablar();
            this.Desplazarse();
            this.Alimentarse();
            this.Dormir();
        }

        /*Metodos estaticos: son aquellos que se pueden usar sin necesidad
         * de instanciar un nuevo objeto de la clase. Siempre son static
         * porque solo se definen una vez por ejecucion estando fijos
         * en una parte de la memoria principal.
        */
        public static void Saludar()
        {
            Console.WriteLine("Hola soy un mensaje desde un metodo estatico");
        }
        public static double Cuadratica(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException("a no puede ser cero.");
            
            double discriminante = b * b - 4 * a * c;
            if (discriminante < 0)
                throw new ArgumentException("discriminante negativo, no se puede");

            return (-b + Math.Sqrt(discriminante) )/ (2*a);
        }

        /*La mayoria de clases abstractas suelen incluir algo conocido
         como metodo de instanciacion el cual es un metodo que permite
        crear un objeto basado en una clase abstracta a traves
        de una clase que sea compatible con ella.
        -> Normalmente a este tipo de metodo se le pone por nombre GetInstance
        -> El tipo de dato de retorno es el de la clase en la que estamos*/
        public static SerVivo GetInstance()
        {
            //retornar una nueva instancia de un objeto compatible
            //con la clase SerVivo
            return new Humano("Sin nombre");
        }
    }
}
