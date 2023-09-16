using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID
{
    internal class LibroSRP
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public string ISBN { get; set; }

        public LibroSRP(string titulo, string autor, string isbn)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
        }
    }
}
