using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.LSVP
{
    internal class CuentaBancariaLSP
    {
        protected decimal Saldo { get; set; }

        public virtual void Depositar(decimal monto) 
        {
            Saldo += monto;
        }

        public virtual void Retirar(decimal monto)
        {
            Saldo -= monto;
        }
    }
}
