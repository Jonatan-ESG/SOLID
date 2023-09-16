using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.DIP
{
    internal class CocheDIP
    {
        private IMotorDIP motor;

        public CocheDIP(IMotorDIP motor)
        {
            this.motor = motor;
        }

        public void ArracarCoche()
        {
            this.motor.Encender();
            Console.WriteLine("Encendido");
        }
        public void ApagarCoche()
        {
            this.motor.Apagar();
            Console.WriteLine("Apagado");
        }
    }
}
