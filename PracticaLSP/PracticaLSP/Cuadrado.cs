using PracticaLSP.Interfaces;

namespace PracticaLSP
{
    public class Cuadrado : FiguraGeometrica, ICalcular
    {
        public Cuadrado(decimal lado) : base(lado, lado) { }
        public decimal CalcularArea() => Base * Base;
    }
}
