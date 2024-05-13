using ProgramaModulo3.Interface;

namespace ProgramaModulo3
{
    public class Empleado : Persona, IViendoInformacion
    {
        private decimal _sueldo;

        public decimal Sueldo
        {
            get => _sueldo; set => _sueldo = value;
        }

        public void VerInfo()
        {
            base.VerInfo();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }
}
