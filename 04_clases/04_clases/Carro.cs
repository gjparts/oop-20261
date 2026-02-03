using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_clases
{
    public class Carro
    {
        //Propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }

        //Constructores
        public Carro()
        {
            this.Marca = "No definida";
            this.Modelo = "No definido";
            this.Color = "No definidao";
            this.Anio = 0;
        }
        public Carro(string marca, string modelo, string color, int anio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.Anio = anio;
        }
        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("******** CARRO ********");
            Console.WriteLine($"Marca: {this.Marca}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Año: {this.Anio}");
        }
    }
}
