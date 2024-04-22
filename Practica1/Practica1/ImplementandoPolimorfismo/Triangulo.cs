namespace Practica1.ImplementandoPolimorfismo
{
    public class Triangulo : Figura
    {
        private double _baseTriangulo;
        private double _alturaTriangulo;

        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            _baseTriangulo = baseTriangulo;
            _alturaTriangulo = alturaTriangulo;
        }

        public override double CalcularArea()
        {
            return 0.5 * _baseTriangulo * _alturaTriangulo;
        }
    }
}
