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

            Factura fac1 = new Factura(1, DateTime.Now, cli1, pr1);
            fac1.Imprimir();

            Factura fac2 = new Factura(2, new DateTime(2026, 2, 20, 9, 37, 0), null, pr3);
            fac2.Producto2 = pr2;
            fac2.Producto3 = pr5;
            fac2.Producto4 = pr1;
            fac2.Imprimir();

            Factura fac3 = new Factura(3, DateTime.Now, cli2, pr4);
            fac3.Producto3 = pr5;
            fac3.Imprimir();

            //Objeto de un solo uso
            new Factura(4, DateTime.Now, cli1, pr2).Imprimir();
        }
    }
}
