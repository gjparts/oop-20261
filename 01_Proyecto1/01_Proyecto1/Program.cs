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

            //posicionar el curso de impresion en una determinada parte de la terminal
            Console.SetCursorPosition(80, 4);
            Console.WriteLine("Texto en la columna 80, linea 4");

            Console.SetCursorPosition(20, 21);
            Console.WriteLine("Texto en la columna 20, linea 21");

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Texto en la columna 0, linea 0");

            //Importante: el texto de aviso que el programa ha terminado se imprime
            //abajo de la ultima linea donde posiciono el cursor.

            //pausar la ejecucion de codigo en la terminal
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true evita que se imprima la tecla presionada

            //limpiar la pantalla
            Console.Clear();

            //variables
            int x = 5;
            double dd = 3.141612344;
            float ff = 2.34567f;
            long num = 1234123412345L;

            //bloque de caza de errores
            try
            {
                //Captura de datos en variables
                int a;
                Console.Write("ingrese un entero: ");
                a = int.Parse( Console.ReadLine() );

                double d1;
                Console.Write("ingrese un valor double: ");
                d1 = double.Parse(Console.ReadLine());

                float f1;
                Console.Write("ingrese un valor float: ");
                f1 = float.Parse(Console.ReadLine());

                long l1;
                Console.Write("ingrese un entero largo: ");
                l1 = long.Parse(Console.ReadLine());

                //imprimir las variables
                Console.WriteLine("Valor de a: "+a); //forma 1, concatenar el valor
                Console.WriteLine($"Valor de a: {a}"); //forma 2, usando interpolacion

                Console.WriteLine($"El valor de d1 es {d1} y el valor de f1 es {f1}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conversion ha fallado");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
