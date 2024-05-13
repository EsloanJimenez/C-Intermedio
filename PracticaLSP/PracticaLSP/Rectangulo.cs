using PracticaLSP.Interfaces;

namespace PracticaLSP
{
    public class Rectangulo : FiguraGeometrica, ICalcular
    {
        public Rectangulo(decimal @base, decimal altura) : base(@base, altura) { }
        public decimal CalcularArea() => Base * Altura;
    }
}
