namespace _15_polimorfismo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Caballo", "Equino", 4, true);
            a1.Hablar();
            a1.Imprimir();

            Gato g1 = new Gato("Misifus", true, true);
            g1.Hablar();
            g1.Ronronear();
            g1.Imprimir();

        }
    }
}
