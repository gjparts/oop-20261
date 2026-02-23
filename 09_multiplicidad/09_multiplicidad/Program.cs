namespace _08_asociacion_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente("Filomeno Colinas","12344321","1234","");
            Cliente cli2 = new Cliente("Estevancito Maravilla", "777777777", "1234", "");

            CategoriaProducto ca1 = new CategoriaProducto("Bebidas","22");
            CategoriaProducto ca2 = new CategoriaProducto("Frutas y Verduras", "1");
            CategoriaProducto ca3 = new CategoriaProducto("Carnes", "2");

            Producto pr1 = new Producto("Coca Cola 3L",ca1,65);
            Producto pr2 = new Producto("Lechuga Unidad", ca2, 18);
            Producto pr3 = new Producto("Papa Libra", ca2, 15);
            Producto pr4 = new Producto("Hot Dog Delicia Bolsa", ca3, 50);
            Producto pr5 = new Producto("Copetin El Sureño Unidad", ca3, 4);

            Producto[] prods1 = { pr1 };
            Factura fac1 = new Factura(1, DateTime.Now, cli1, prods1);
            fac1.Imprimir();

            Producto[] prods2 = { pr3, pr2, pr5, pr1 };
            Factura fac2 = new Factura(2, new DateTime(2026, 2, 20, 9, 37, 0), null, prods2);
            fac2.Imprimir();

            Producto[] prods3 = { pr4, pr5 };
            Factura fac3 = new Factura(3, DateTime.Now, cli2, prods3);
            fac3.Imprimir();

            //Objeto de un solo uso
            Producto[] prods4 = { pr2, pr1, pr1, pr1, pr2, pr3, pr5, pr2, pr1, pr1, pr1 };
            new Factura(4, DateTime.Now, cli1, prods4).Imprimir();

            try
            {
                //arreglo de productos no puede ser null en la factura:
                //Factura fac123 = new Factura(123, DateTime.Now, cli2, null);
                //fac123.Imprimir();

                //arreglo debe de tener al menos un item
                //Producto[] prodsX = { };
                //Factura fac123 = new Factura(123, DateTime.Now, cli2, prodsX);
                //fac123.Imprimir();

                //item 0 del arreglo no puede ser null
                /*Producto[] prodsX = { null };
                Factura fac123 = new Factura(123, DateTime.Now, cli2, prodsX);
                fac123.Imprimir();*/

                //puede haber null siempre y cuando no sea el item 0
                Producto[] prodsX = { pr5, pr1, pr1, null, pr2, null, null, pr1 };
                Factura fac123 = new Factura(123, DateTime.Now, cli2, prodsX);
                fac123.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
