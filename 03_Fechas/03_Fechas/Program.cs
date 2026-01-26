namespace _03_Fechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Para manejar fechas en C# puede usar los tipos de dato siguientes:
             DateTime   para fecha y hora
             DateOnly   para unicamente fecha
             TimeOnly   para unicamente Hora
             DateOnly y TimeOnly existen a partir de la version 6 de .Net*/

            //obtener fecha/hora actuales de la PC

            //reloj en pantalla
            DateTime hoy;
            while (true)
            {
                hoy = DateTime.Now;
                Console.WriteLine(hoy);
                Thread.Sleep(1000);
                Console.Clear();
            }
                


        }
    }
}
