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

            
        }
    }
}
