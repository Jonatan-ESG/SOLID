using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.ISP
{
    internal interface IDocumentoNoISP
    {
        void Abrir();
        void Cerrar();
        void Guardar();

    }
}
