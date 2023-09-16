using PrincipiosSOLID.LSVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.LSP
{
    internal class CuentaAhorroNoLSP: CuentaBancariaNoLSP
    {
        private decimal TasaInteresMensual = 0.01m;

        public override void Retirar(decimal monto)
        {
            //Aplicar lógica para validar si debo aplicar la tasa de interes mensual

            Saldo = Saldo * (TasaInteresMensual + 1);

            Saldo -= monto;
        }
    }
}
