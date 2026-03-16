namespace _18_abstraccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo(4, 5);
            Console.WriteLine($"Area de r1: {r1.CalcularArea()}");
            Console.WriteLine($"Perimetro de r1: {r1.CalcularPerimetro()}");
            Console.WriteLine("---------------------");

            Circulo c1 = new Circulo(7);
            Console.WriteLine($"Area de c1: {c1.CalcularArea()}");
            Console.WriteLine($"Perimetro de c1: {c1.CalcularPerimetro()}");
            Console.WriteLine("---------------------");

            TrianguloEquilatero t1 = new TrianguloEquilatero(2, 3);
            Console.WriteLine($"Area de t1: {t1.CalcularArea()}");
            Console.WriteLine($"Perimetro de t1: {t1.CalcularPerimetro()}");
            Console.WriteLine("----------------------");

            //Recuerde que Figura se puede apuntar a un objeto
            //que sea compatible con la clase abstracta
            Figura f1 = c1;
            Console.WriteLine($"Area de f1: {f1.CalcularArea()}");
            Console.WriteLine($"Perimetro de f1: {f1.CalcularPerimetro()}");
            Console.WriteLine("---------------------");


        }
    }
}
