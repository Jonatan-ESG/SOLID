using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.DIP
{
    internal class CocheNoDIP
    {
        private MotorNoDIP motorNoDIP =  new MotorNoDIP();

        public void ArracarCoche()
        {
            motorNoDIP.Encender();
        }
        public void ApagarCoche()
        {
            motorNoDIP.Apagar();
        }
    }
}
