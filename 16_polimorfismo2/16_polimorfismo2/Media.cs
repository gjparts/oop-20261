using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_herencia2
{
    public class Media : File
    {
        //Propiedades
        public Author Author { get; set; }
        public int Duration { get; set; }

        //Constructor
        public Media(string name, int size, string extension,
            DateTime creationDate, Author author, int duration)
            : base(name, size, "Media file", extension, creationDate)
        {
            this.Author = author;
            this.Duration = duration;
        }

        //Metodos
        public override void Print()
        {
            base.Print(); //override parcial
            //relacion por agregacion
            if (this.Author != null)
            {
                Console.WriteLine($"Author: {this.Author.Name}");
            }
            Console.WriteLine($"Duration: {this.Duration}");
        }
    }
}
