using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_herencia2
{
    public class Video : Media
    {
        //Propiedades
        public String Codec {  get; set; }
        public int Chapters { get; set; }
        public string[] Audio {  get; set; }
        public List<Subtitle> Subtitles { get; set; }

        //Constructor
        public Video(string name, int size, string extension,
            DateTime creationDate, Author author, int duration,
            string codec, int chapters, string[] audio, List<Subtitle> subtitles)
            : base(name, size, extension, creationDate, author, duration)
        {
            //colocar el type a conveniencia:
            this.Type = "Video/Movie file";

            this.Codec = codec;
            this.Chapters = chapters;
            this.Audio = audio;
            this.Subtitles = subtitles;
        }

        //Metodos
        public override void Print()
        {
            base.Print(); //override parcial
            Console.WriteLine($"Codec: {this.Codec}");
            Console.WriteLine($"Chapters: {this.Chapters}");
            
            //pistas de audio
            if( this.Audio != null)
            {
                Console.WriteLine("Audio tracks:");
                foreach( string item in this.Audio)
                {
                    Console.WriteLine($"\t* {item}");
                }
            }

            //subtitulos
            if( this.Subtitles != null)
            {
                Console.WriteLine("Subtitles:");
                foreach(Subtitle item in this.Subtitles)
                {
                    if( item != null)
                    {
                        Console.WriteLine($"\t* {item.Language}");
                    }
                }
            }
        }
    }
}
