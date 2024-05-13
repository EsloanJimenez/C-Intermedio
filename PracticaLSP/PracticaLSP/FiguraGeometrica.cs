namespace PracticaLSP
{
    public class FiguraGeometrica
    {
        public decimal Base {get; set;}
        public decimal Altura { get; set;}

        public FiguraGeometrica(decimal @base, decimal altura)
        {
            Base = @base;
            Altura = altura;
        }
    }
}
