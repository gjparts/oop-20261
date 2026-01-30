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

            Mascota m1 = new Mascota();
            m1.Nombre = "Firulais";
            m1.Especie = "Perro";
            m1.Genero = 'M';
            m1.Pedigree = true;
            Console.WriteLine("******************");
            Console.WriteLine("Propiedades de m1:");
            Console.WriteLine($"Nombre: {m1.Nombre}");
            Console.WriteLine($"Especie: {m1.Especie}");
            Console.WriteLine($"Genero: {m1.Genero}");
            Console.WriteLine($"Pedigree: {m1.Pedigree}");
            Console.WriteLine($"Hash de memoria: {m1.GetHashCode()}");

            Persona per1 = new Persona();
            Console.ForegroundColor = ConsoleColor.Yellow;
            per1.Imprimir();

            //modificar una de las propiedades de per1:
            per1.Nombre = "Gerardo Portillo";
            Console.WriteLine($"Nombre actualizado: {per1.Nombre}");

            Console.ResetColor();

            Persona per2 = new Persona("Josue Portillo", 13, 'M', "1234123412345");
            per2.Imprimir();

            Persona per3 = new Persona("Filomeno Colinas", 77);
            per3.Genero = 'M';
            per3.Imprimir();

            Console.WriteLine($"{per1.Nombre} es mayor de edad? {per1.EsMayorDeEdad()}");
            Console.WriteLine($"{per2.Nombre} es mayor de edad? {per2.EsMayorDeEdad()}");
            Console.WriteLine($"{per3.Nombre} es mayor de edad? {per3.EsMayorDeEdad()}");
            if( per2.EsMayorDeEdad() == true )
                Console.WriteLine($"{per2.Nombre} si puede salir en su moto italika");
            else
                Console.WriteLine($"{per2.Nombre} ni loco puede salir en su italika");
        }
    }
}
