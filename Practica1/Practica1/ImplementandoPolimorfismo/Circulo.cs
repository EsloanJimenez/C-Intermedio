namespace Practica1.ImplementandoPolimorfismo
{
    public class Circulo : Figura
    {
        private double _radio;

        public Circulo(double radio)
        {
            _radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(_radio, 2);
        }
    }
}
