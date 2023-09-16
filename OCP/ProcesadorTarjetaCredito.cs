using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.OCP
{
    internal class ProcesadorTarjetaCredito: IMetodoPago
    {
        private string NumeroTarjeta;
        public ProcesadorTarjetaCredito(string numeroTarjeta)
        {
            NumeroTarjeta = numeroTarjeta;
        }
        public bool ProcesarPago(decimal monto)
        {
            //Lógica para procesar TarjetaCredito
            return true;
        }
    }
}
