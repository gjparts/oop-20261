namespace _04_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*en C# para nombrar variables y
             constantes locales se recomienda
            usar camel Case o Snake Case, ejemplos:
            Camel Case o notacion Hungara: (primera letra minusc. demas en mayusc)
            arbol1
            cuentaAhorro1
            salarioEmpleadoEmpresa46

            Snake Case: (todo en minusculas, espacios son guion bajo)
            arbol1
            cuenta_ahorro1
            salario_empleado_empresa46
            */

            //instanciar un objeto de clase Arbol
            Arbol a1 = new Arbol();
            //leer (get) algunas propiedades de a1
            Console.WriteLine(a1.Edad);
            Console.WriteLine(a1.Especie);
            //escribir (set) datos a las propiedades de a1:
            a1.Edad = 100;
            a1.Especie = "Ceiba Penthandra";
            a1.Altura = 6.3f;
            a1.Nombre = "El palon de la esquina";
            //volver a leer las propiedades actualizadas de a1:
            Console.WriteLine("Propiedades de a1:");
            Console.WriteLine($"Nombre: {a1.Nombre}");
            Console.WriteLine($"Edad: {a1.Edad}");
            Console.WriteLine($"Especie: {a1.Especie}");
            Console.WriteLine($"Altura: {a1.Altura}");
            //ejecucion del unico metodo que le pusimos al Arbol:
            a1.Purificar();
        }
    }
}
