using PrincipiosSOLID.DIP;

namespace PrincipiosSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            V8MotorDIP motorV8 = new V8MotorDIP("SERIE_COOL");

            CocheDIP cocheDipV8 = new CocheDIP(motorV8);

            cocheDipV8.ArracarCoche();

            MotorDIP motor = new MotorDIP();


            CocheDIP cocheDip = new CocheDIP(motor);

            cocheDipV8.ArracarCoche();

            CocheNoDIP cocheNo = new CocheNoDIP();

            cocheDip.ArracarCoche();
        }
    }
}