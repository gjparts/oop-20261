namespace _13_herencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante es1 = new Estudiante("Gerardo", 43, Enum.Genero.Masculino, "20012002049", "Ing. Industrial");
            Console.WriteLine("Datos de es1: **************");
            Console.WriteLine($"Nombre: {es1.Nombre}");
            Console.WriteLine($"Edad: {es1.Edad}");
            Console.WriteLine($"Genero: {es1.Genero}");
            Console.WriteLine($"Cuenta: {es1.Cuenta}");
            Console.WriteLine($"Nombre: {es1.Carrera}");
            es1.Saludar();
            es1.Estudiar();
            /*Observe que Estudiante como hereda de la clase Persona tiene
             las propiedades Nombre, Edad, Genero asi como las propiedades
            Cuenta y Carrera. La clase Estudiante tambien tiene acceso a los
            metodos Saludar y Estudiar.*/

            Empleado e1 = new Empleado();
            Console.WriteLine("Datos de e1: **************");
            Console.WriteLine($"Nombre: {e1.Nombre}");
            Console.WriteLine($"Edad: {e1.Edad}");
            Console.WriteLine($"Genero: {e1.Genero}");
            Console.WriteLine($"Salario: {e1.Salario}");
            Console.WriteLine($"Cargo: {e1.Cargo}");
            e1.Saludar(); //metodo heredado
            e1.Trabajar();

            Empleado e2 = new Empleado("Homero Simpson", 45, Enum.Genero.Masculino, 20000, "Supervisor");
            Console.WriteLine("Datos de e2: **************");
            Console.WriteLine($"Nombre: {e2.Nombre}");
            Console.WriteLine($"Edad: {e2.Edad}");
            Console.WriteLine($"Genero: {e2.Genero}");
            Console.WriteLine($"Salario: {e2.Salario}");
            Console.WriteLine($"Cargo: {e2.Cargo}");
            e2.Saludar(); //metodo heredado
            e2.Trabajar();

            Practicante pr1 = new Practicante("John Doe", 19, Enum.Genero.Masculino, 6);
            Console.WriteLine("Datos de pr1.: **************");
            Console.WriteLine($"Nombre: {pr1.Nombre}");
            Console.WriteLine($"Edad: {pr1.Edad}");
            Console.WriteLine($"Genero: {pr1.Genero}");
            Console.WriteLine($"Salario: {pr1.Salario}");
            Console.WriteLine($"Cargo: {pr1.Cargo}");
            Console.WriteLine($"Meses: {pr1.Meses}");
            pr1.Saludar(); //metodo heredado
            pr1.Trabajar();

            Catedratico cat1 = new Catedratico("Gerardo", 43, Enum.Genero.Masculino,
                18000, "Ing. en Computacion");
            Console.WriteLine("Datos de cat1.: **************");
            Console.WriteLine($"Nombre: {cat1.Nombre}");
            Console.WriteLine($"Edad: {cat1.Edad}");
            Console.WriteLine($"Genero: {cat1.Genero}");
            Console.WriteLine($"Salario: {cat1.Salario}");
            Console.WriteLine($"Cargo: {cat1.Cargo}");
            Console.WriteLine($"Profesion: {cat1.Profesion}");
            cat1.Saludar(); //metodo heredado
            cat1.Trabajar();
            cat1.Educar();
        }
    }
}
