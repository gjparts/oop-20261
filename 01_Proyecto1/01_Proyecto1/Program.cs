namespace _01_Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bases de C#
            /*comentario de
             varias
            lineas*/
            Console.WriteLine("Imprime y pasa a la siguiente linea");
            Console.Write("Imprime y no pasa a la siguiente linea");
            Console.Write("Hola UNAH");
            Console.Write("Sistemas");
            Console.WriteLine(); //nuevo renglon
            //puede usar caracteres de escape como en C++
            Console.WriteLine("gato\nperro\nloro\njirafa");

            //dar color al texto en la terminal
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Linea con texto amarillo");

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Linea con texto amarillo y fondo violeta");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("prueba de color 1");

            //resetear los colores de la consola
            Console.ResetColor();

            //se puede poner varios colores por linea?
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write("Fresa");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Uva");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Naranja");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Sandia");

            Console.ResetColor();
            Console.WriteLine();

            //pausar la ejecucion de codigo en la terminal
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true evita que se imprima la tecla presionada

            //limpiar la pantalla
            Console.Clear();

            //para poder imprmir String de multiples lineas use @ antes del String
            Console.WriteLine(@"String de
varios
renglones
y que ignora los caracteres de escape \n\n\n\n\n fin");

            //pausar la ejecucion de codigo en la terminal
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true evita que se imprima la tecla presionada

            //limpiar la pantalla
            Console.Clear();

        }
    }
}
