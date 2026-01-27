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
            DateTime hoy = DateTime.Now;

            //reloj en pantalla
            /*
            DateTime hoy;
            while (true)
            {
                hoy = DateTime.Now;
                Console.WriteLine(hoy);
                Thread.Sleep(1000);
                Console.Clear();
            }*/

            //DateTime no puede asignarse a null de forma nativa
            //DateTime x = null;
            //a menos que Usted agregue el modificador respectivo
            //para ignorar la regla anterior:
            DateTime? x = null;
            Console.WriteLine(x);

            //el modicador ? en C# se coloca junto al tipo de dato
            //y este permite declarar una variable sin inicializar
            //pero que puede ser referenciada.
            int? numero = null;
            Console.WriteLine(numero);

            //guardar solo la hora
            TimeOnly hora = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(hora);

            //guardar solo la fecha
            DateOnly fecha = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(fecha);

            //establecer una fecha y hora fijas
            DateTime fecha2 = new DateTime(1982, 10, 15, 7, 33, 24);
            Console.WriteLine(fecha2);

            //establecer una hora fija
            TimeOnly hora2 = new TimeOnly(17, 30, 3);
            Console.WriteLine(hora2);

            //establecer una fecha fija
            DateOnly fecha3 = new DateOnly(1982, 10, 15);
            Console.WriteLine(fecha3);

            //imprimir DateTime usando formatos predefinidos
            Console.WriteLine("Fecha corta: "+hoy.ToShortDateString());
            Console.WriteLine("Fecha larga: "+hoy.ToLongDateString());

            //imprimir DateTime usando una mascara de entrada
            Console.WriteLine("Fecha con formato: "+hoy.ToString("yyyy/MM/dd hh:mm:ss tt"));

            //convertir un String a DateTime
            String str = "25/12/2025 19:34:56";
            DateTime fecha4 = DateTime.Parse(str);
            Console.WriteLine(fecha4);

            //Operaciones con fechas
            Console.WriteLine("******************************************");
            DateTime abc = DateTime.Now;

            //Sumar 5 dias a la fecha abc
            abc = abc.AddDays(5);
            Console.WriteLine(abc);

            //Restar 1 mes a la fecha abc
            abc = abc.AddMonths(-1);
            Console.WriteLine(abc);

            //Comparacion de fechas
            try
            {
                DateTime a, b;
                Console.Write("Digite fecha A: ");
                a = DateTime.Parse( Console.ReadLine() );
                Console.Write("Digite fecha B: ");
                b = DateTime.Parse(Console.ReadLine());

                //son iguales?
                if( a == b )
                    Console.WriteLine("Ambas fechas son iguales");
                else
                {
                    Console.WriteLine("Ambas fechas no son iguales");

                    if (a > b)
                        Console.WriteLine("Fecha A es mayor a la fecha B");
                    else
                        Console.WriteLine("Fecha B es mayor a la fecha A");
                }

                //Obtener la diferencia en dias entre las dos fechas
                TimeSpan diferencia;
                if (a > b)
                    diferencia = a - b;
                else
                    diferencia = b - a;

                Console.WriteLine("Diferencia en dias entre A y B: "+diferencia.Days);
                Console.WriteLine("Diferencia en horas entre A y B: " + diferencia.TotalHours);
                Console.WriteLine("Diferencia en minutos entre A y B: " + diferencia.TotalMinutes);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valores digitados incorrectos.");
            }
        }
    }
}
