using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_herencia2
{
    public class Audio : Media
    {
        //Propiedades
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public int Track { get; set; }

        //Constructor
        public Audio(string name, int size, string extension,
            DateTime creationDate, Author author, int duration,
            string artist, string album, int year, int track)
            : base(name,size, extension, creationDate, author, duration)
        {
            //colocar el type a conveniencia:
            this.Type = "Audio file";

            this.Artist = artist;
            this.Album = album;
            this.Year = year;
            this.Track = track;
        }

        //Metodos
        public override void Print()
        {
            base.Print(); //override parcial
            Console.WriteLine($"Artist {this.Artist}");
            Console.WriteLine($"Album: {this.Album}");
            Console.WriteLine($"Year: {this.Year}");
            Console.WriteLine($"Track: {this.Track}");
        }
    }
}
