using PrincipiosSOLID.LSVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.LSP
{
    internal class CuentaCorrienteLSP: CuentaBancariaLSP
    {
        public override void Retirar(decimal monto)
        {
            if (monto <= Saldo)
            {
                Saldo -= monto;
            }
            else
            {
                throw new InvalidOperationException("Saldo insuficiente para el retiro.");
            }
        }
    }
}
