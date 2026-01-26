namespace _02_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Sumar(2,3) );
            Saludar();
            Console.WriteLine(Adicionar(5,4) );
            Despedirse();
        }

        //Metodos o funciones tradicionales
        static double Sumar(double a, double b)
        {
            return a + b;
        }
        static void Saludar()
        {
            Console.WriteLine("Hola");
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Adios");
        }

        //Funciones de flecha: se recomiendan cuando lo que vamos
        //a retornar es simple o depende de una sola instruccion
        static double Adicionar(double a, double b) => a + b;
        static void Despedirse() => Console.WriteLine("Hasta pronto.");
    }

    
}
