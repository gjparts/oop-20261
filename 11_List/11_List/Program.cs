namespace _11_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List: permite crear una coleccion que puede cambiar
             su tamaño de forma dinamica, sus elementos se posicionan
            de forma aleatoria en la memoria.
            List permite almacenar elementos ya sean homogeneos o heterogeneos.*/

            //Coleccion heterogenea: cada item puede ser de un tipo distinto
            List<object> lista1 = new List<object>();
            /*observe el termino <object> cuando se encierra el tipo
             de dato de List, a lo que se encierra en <> se le conoce
            como Generics y lo que hacen es determinar el tipo de dato
            soportado por una coleccion.
            object es un objeto compatible con todas las clases de C#
            ya que es heredada por cualquier clase en este lenguaje.*/

            //Agregar items a la lista
            lista1.Add("UNAH");
            lista1.Add(200);
            lista1.Add(4.5f);
            lista1.Add('Z');
            lista1.Add(2.1345);
            lista1.Add(DateTime.Now);
            lista1.Add("Gerardo");
            //Importante: en una coleccion heterogenea si no esta seguro
            //de lo que esta haciendo puede llegar a confundirse.

            //Imprimir un List usando for tradicional
            for(int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine(lista1[i]);
            }
            //en un List los elementos se numeran de 0 a N-1 (Zero indexing)

            //Imprimir usando foreach
            Console.WriteLine("***********************");
            foreach(object item in lista1)
                Console.WriteLine(item);
            //se pone object para cada item porque en lista1 todos sus elementos
            //son object.

            //Imprimir usando Join
            Console.WriteLine("***********************");
            Console.WriteLine( String.Join("\n",lista1) );
            /*String.Join se puede usar con cualquier coleccion
             * (arreglo, List, etc.)
             \n es el separador entre elementos impresos
            String.Join devuelde un String compuesto por todos los elementos
            de la coleccion.*/

            //El tamaño de un List
            Console.WriteLine($"Tamaño de lista1 es {lista1.Count}");

            //Coleccion homogenea: todos sus elementos son del mismo tipo
            //List de elementos string
            List<string> lista2 = new List<string>();
            lista2.Add("Rojo");
            lista2.Add("Amarillo");
            lista2.Add("Azul");
            lista2.Add("Verde");

            Console.WriteLine("***********************");
            Console.WriteLine(String.Join("\n", lista2));

            //Coleccion homogenea de numeros enteros
            List<int> lista3 = new List<int>();
            lista3.Add(200);
            lista3.Add(-777);
            lista3.Add(123);
            lista3.Add(2);
            lista3.Add(8);

            Console.WriteLine("***********************");
            Console.WriteLine(String.Join("\n", lista3));

            //Leer un item que esta en determina posicion
            //de un List (use corchetes como si fuera arreglo)
            Console.WriteLine($"item 0 en lista3: {lista3[0]}");
            Console.WriteLine($"item 3 en lista1: {lista1[3]}");
            Console.WriteLine($"item 2 en lista2: {lista2[2]}");

            //Eliminar un elemento dentro de un List en determinada posicion
            lista2.RemoveAt(1);

            Console.WriteLine("***********************");
            Console.WriteLine(String.Join("\n", lista2));

            //Add lo usamos para agregar un item al final del List
            //Insert lo usamos para agregar un item en determinada
            //posicion del List
            lista2.Insert(1, "Verde olivo");

            Console.WriteLine("***********************");
            Console.WriteLine(String.Join("\n", lista2));

            //Si desea sobreescribir un elemento existente
            //en determinada posicion hagalo como lo hacia en los arreglos:
            lista2[2] = "Salmon";

            Console.WriteLine("***********************");
            Console.WriteLine(String.Join("\n", lista2));
        }
    }
}
