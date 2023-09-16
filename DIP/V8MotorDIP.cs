using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID.DIP
{
    internal class V8MotorDIP : IMotorDIP
    {
        string serie;

        public V8MotorDIP(string serie)
        {
            this.serie = serie;
        }

        public void Encender()
        {
            // Lógica para encender el motor.
        }

        public void Apagar()
        {
            // Lógica para apagar el motor.
        }

        public void EncenderTurbo()
        { 
            // Lógica para encender turbo
        }
    }
}
