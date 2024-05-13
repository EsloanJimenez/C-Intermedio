using PracticaLSP;


//FiguraGeometrica figuraGeometrica = new FiguraGeometrica();
Rectangulo rectangulo = new Rectangulo(25.8m, 38.7m);
Cuadrado cuadrado = new Cuadrado(7);

Console.WriteLine($"El area del rectangulo es: {rectangulo.CalcularArea()}");
Console.WriteLine($"El area del cuadrado es: {cuadrado.CalcularArea()}");
