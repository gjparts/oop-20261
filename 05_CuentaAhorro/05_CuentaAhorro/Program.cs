namespace _05_CuentaAhorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CuentaAhorro a1 = new CuentaAhorro("Gerardo","12345");
                Console.WriteLine($"Saldo: {a1.Saldo}");
                a1.Depositar(1000);
                Console.WriteLine($"Saldo: {a1.Saldo}");
                //a1.Depositar(-100);
                a1.Retirar(150);
                Console.WriteLine($"Saldo: {a1.Saldo}");
                //a1.Retirar(-10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
