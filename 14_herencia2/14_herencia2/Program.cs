namespace _14_herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("Gerardo", "califik.com", "");

            Document doc1 = new Document("Tesis", 75556, "pdf", DateTime.Now,
                a1, DateTime.Now, 100);
            doc1.Print();

            DateTime fecha1 = new DateTime(2017, 10, 15);
            Author a2 = new Author("Metallica", "", "");
            Audio song1 = new Audio("One", 3942443, "mp3", fecha1, a2, 445, "Metallica",
                "...and justice for all", 1988, 4);
            song1.Print();

            string[] pistas = { "Ingles","Español latino", "Español castellano" };
            List<Subtitle> subtitulos = new List<Subtitle>();
            subtitulos.Add(new Subtitle("Español", null));
            subtitulos.Add(new Subtitle("Ingles", new Author("GNula","","") ));

            Video peli1 = new Video("Flow", 23123123, "mp4", DateTime.Now, null, 10800,
                "h264", 7, pistas, subtitulos);
            peli1.Print();
        }
    }
}
