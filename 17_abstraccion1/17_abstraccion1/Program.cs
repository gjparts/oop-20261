namespace _17_abstraccion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //en C# y JAVA una clase abstracta no puede ser instanciada
            //de manera tradicional:
            //SerVivo s1 = new SerVivo("Equino");
            //Esto se debe a que una clase abstracta
            //se diseña para ser Heredada.

            Gato g1 = new Gato("Misifus");
            g1.Vivir();
            Console.WriteLine("---------------------");
            Humano h1 = new Humano("Gerardo");
            h1.Hablar();
            h1.Vivir();

            //La ventaja de una clase abstracta es que permite
            //estandarizar los metodos

            //Una clase abstracta puede ser instanciada a traves
            //de un objeto que sea compatible
            //en este caso cualquier objeto cuya class herede de la
            //clase abastracta:
            Console.WriteLine("----------------------");
            SerVivo s = new Humano("Ash Ketchup");
            s.Vivir();
            s = new Gato("Tinieblo");
            s.Vivir();

            //otro uso practico es para hacer colecciones
            //de objetos compatibles:
            Console.WriteLine("------------------------------");
            List<SerVivo> seres = new List<SerVivo>();
            seres.Add(g1);
            seres.Add(h1);
            seres.Add(s);
            seres.Add( new Gato("Raul") );
            seres.Add( new Humano("Filomeno" ) );
            foreach(SerVivo item in seres)
            {
                item.Vivir();
            }


        }
    }
}
