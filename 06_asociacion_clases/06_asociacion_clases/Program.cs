namespace _06_asociacion_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primero se crea los objetos de las clases no dependientes
            Fabricante samsung = new Fabricante("Samsung","Korea", "No se quien es");
            Fabricante apple = new Fabricante("Apple Computer Inc.", "USA", "Tim Cook");
            Fabricante huawei = new Fabricante("Huawei Inc.", "China", "N/A");
            Fabricante lg = new Fabricante("LG Chemical", "Korea", "N/A");

            Operador tigo = new Operador("TIGO", "Centroamerica");
            Operador claro = new Operador("Claro","Honduras");

            Bateria bat1 = new Bateria(lg, 6600);
            Bateria bat2 = new Bateria(lg, 4500);
            Bateria bat3 = new Bateria(new Fabricante("CATL", "Hong Kong", "N/A"), 5500);
            /*Observe que tambien es posible crear un objeto dentro del constructor
             de otro, o sea un objeto sin asignar a una variable.
            Cuando Usted considere que un objeto solo lo va a referencia una sola vez
            no es necesario apuntarlo a una variable (como en este caso CATL)
            En cambio si Usted considera que un objeto va a ser referencia muchas
            veces, lo mejor es depositar este objeto en una variable como hicimos con
            las baterias de la marca lg.*/

            Chip sim1 = new Chip(tigo, 99152959);
            Chip sim2 = new Chip(claro, 33331515);
            Chip sim3 = new Chip(tigo, 98989898);
            Chip sim4 = new Chip(new Operador("Digicel","Guatemala"),89897777);
            //observe que el operador Digicel es un objeto de un solo uso como explicamos arriba
            //el objeto para Digicel queda alojado en la propiedad Proveedor de sim4 por lo tanto
            //no se borrará a traves del recolector de basura.

            //creacion de smartphones
            SmartPhone cel1 = new SmartPhone(apple, "iPhone 17 PRO Max", Enum.Capacidad.c512GB,
                Enum.Capacidad.c8GB, bat1, sim1, null);
            //observe que iPhone solo tiene para un chip por eso el Chip2 lo asignamos a null
            cel1.Imprimir();

            SmartPhone cel2 = new SmartPhone(samsung, "Galaxy s24", Enum.Capacidad.c256GB,
                Enum.Capacidad.c8GB, bat3, sim2, sim4);
            cel2.Imprimir();

            //tambien se puede crear un objeto volatil de un solo uso para Imprimir:
            new SmartPhone(huawei,"P60",Enum.Capacidad.c64GB,Enum.Capacidad.c6GB,bat2,null,sim2).Imprimir();
            //el objeto anterior nace, ejecuta y muere (se va al recolector de basura o Garbage collector)
        }
    }
}
