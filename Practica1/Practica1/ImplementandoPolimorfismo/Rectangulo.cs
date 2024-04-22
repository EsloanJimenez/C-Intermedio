namespace Practica1.ImplementandoPolimorfismo
{
    public class Rectangulo : Figura
    {
        private double _baseRectangulo;
        private double _alturaRectangulo;
        
        public Rectangulo(double alturaRectangulo,  double baseRectangulo)
        {
            _baseRectangulo = baseRectangulo;
            _alturaRectangulo = alturaRectangulo;
        }
        public override double CalcularArea()
        {
            return _baseRectangulo * _alturaRectangulo;
        }
    }
}
