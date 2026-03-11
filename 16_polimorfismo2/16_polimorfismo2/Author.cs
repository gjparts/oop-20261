using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_herencia2
{
    public class Author
    {
        //Propiedades
        public string Name { get; set; }
        public string Website { get; set; }
        public string EMail { get; set; }

        //Constructor
        public Author(string name, string website, string email)
        {
            this.Name = name;
            this.Website = website;
            this.EMail = email;
        }
    }
}
