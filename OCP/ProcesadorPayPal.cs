using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.OCP
{
    internal class ProcesadorPayPal: IMetodoPago
    {
        private string Username;
        private string Token;
        private string Validador;

        public ProcesadorPayPal(string username, string token, string validador)
        {
            Username = username;
            Token = token;
            Validador = validador;
        }
        public bool ProcesarPago(decimal monto)
        {
            //Lógica para procesar PayPal
            return true;
        }
    }
}
