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

            Diploma d1 = new Diploma("INFOP", "Torno y fresa");
            Diploma d2 = new Diploma("INFOP", "Reparacion de motores gasolina");
            List<Diploma> lista1 = new List<Diploma>();
            lista1.Add(d1);
            lista1.Add(d2);
            lista1.Add(new Diploma("UDEMY","Flutter de cero a experto"));

            Persona per1 = new Persona("111111","Gerardo","9999999");
            per1.Direccion = dir1;
            per1.EmpresaLabora = emp1;
            per1.Mascotas = arreglo;
            per1.Diplomas = lista1;
            per1.Imprimir();

            Persona per2 = new Persona("1234","Homero Simpson","12341234");
            Persona per3 = new Persona("4321", "Marge Simpson", "777777777");
            Persona per4 = new Persona("1111", "Bart Simpson", "1111111111");
            Persona per5 = new Persona("2222", "Lisa Simpson", "3434222234");
            Persona per6 = new Persona("3333", "Maggie Simpson", "43535354");

            per2.Conyuge = per3;

            List<Persona> lista2 = new List<Persona>();
            lista2.Add(per4);
            lista2.Add(per5);
            lista2.Add(per6);

            per2.Hijos = lista2;
            per2.Imprimir();

            //ahora para Marge:
            per3.Conyuge = per2;
            per3.Hijos = lista2;
            per3.Imprimir();
        }
    }
}
