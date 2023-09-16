using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.ISP
{
    internal class DocumentoWordISP: IAbrible, IGuardable, ICerrable
    {
        public void Abrir()
        {
            //Lógica para abrir el archivo
        }
        public void Cerrar()
        {
            //Lógica para cerrar el archivo
        }
        public void Guardar()
        {
            //Lógica para guardar el archivo
        }

    }
}
