namespace _10_multiplicidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barrio b1 = new Barrio("El Carmen", "Este", "21101");
            Barrio b2 = new Barrio("Villas del Sol", "Oste", "21102");

            Direccion dir1 = new Direccion(b1);
            dir1.Calle = "Principal";
            dir1.Avenida = "Centro de Salud";
            dir1.Casa = "1033";

            Direccion dir2 = new Direccion(b2);
            dir2.Calle = "4";
            dir2.Avenida = "7";
            dir2.Casa = "123";

            Empresa emp1 = new Empresa("2G S. de R.L.", dir2, "5555-5555");

            Persona per0 = new Persona("1234567890","Filomeno Colinas","7777777");
            per0.Imprimir();

            Mascota ma1 = new Mascota("Killer", "Perro");
            Mascota ma2 = new Mascota("Misifus", "Gato");
            Mascota[] arreglo = { ma1, ma2, new Mascota("Paquito","Loro") };

            Persona per1 = new Persona("111111","Gerardo","9999999");
            per1.Direccion = dir1;
            per1.EmpresaLabora = emp1;
            per1.Mascotas = arreglo;
            per1.Imprimir();


        }
    }
}
