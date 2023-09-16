using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.OCP
{
    internal interface IMetodoPago
    {
        bool ProcesarPago(decimal monto);
    }
}
