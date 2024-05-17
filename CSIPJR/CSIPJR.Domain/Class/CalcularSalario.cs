namespace CSIPJR.Domain.Class
{
    public abstract class CalcularSalario
    {
        public abstract decimal Calcular();

        public class CalcularSalarioContratado : CalcularSalario
        {
            public override decimal Calcular()
            {
                throw new NotImplementedException();
            }
        }

        public class CalcularSalarioPermanente : CalcularSalario
        {
            public override decimal Calcular()
            {
                throw new NotImplementedException();
            }
        }
        public enum TipoEmpleado
        {
            Contratado,
            Permanente
        }
    }
}
