using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID
{
    internal class ProcesadorPagosNoOCP
    {
        public bool ProcesarPagoTarjetaCredito(string numeroTarjeta, decimal monto)
        {
            //Lógica validar Tarjeta de Crédito
            return true;
        }

        public bool ProcesarPagoPayPal(string username, string token, string validador)
        {
            //Lógica validar PayPal
            return true;
        }
    }
}
