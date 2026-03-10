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

            Perro p1 = new Perro("Duke","Pastor Aleman",true);
            p1.Jugar();
            p1.Hablar();
            p1.Imprimir();

            //Toda clase hereda de Object, por lo tanto cualquier
            //objeto tendra disponible el metodo ToString()
            //el cual devuelve el objeto convertido a String
            Console.WriteLine(g1.ToString());
            Console.WriteLine(p1.ToString());
            //a ToString() podemos hacerle override desde nuestras clases,
            //por ejemplo para la clase Gato.

            //en C# son el simple hecho de imprimir el objeto
            //es lo mismo que mandar a imprimir su metodo toString()
            Console.WriteLine(g1);
        }
    }
}
