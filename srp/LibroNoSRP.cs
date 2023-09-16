using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID
{
    internal class LibroNoSRP
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public LibroNoSRP(string titulo, string autor) { 
            Titulo = titulo;
            Autor = autor;
        }

        public decimal CalcularMulta(DateTime fechaDevolucion)
        {
            //Lógica para calcula multas.
            return 0;
        }

        public void GenerarInformeEstadisticas()
        {
            //Lógica para generar informes.
        }
    }
}
