using static System.Console;
using Practica1;
using Practica1.ImplementandoPolimorfismo;

/*
Persona persona = new Persona("Enrique", 30, "Santo Domingo");

persona.getInfo();

Estudiante estudiante = new Estudiante("Enrique", 30, "Santo Domingo", "Desarrollo De Software", 144358);

estudiante.getInfo();
*/

double alturaRectangulo, baseRectangulo, radio, baseTriangulo, alturaTriangulo;

alturaRectangulo = baseRectangulo = radio = baseTriangulo = alturaTriangulo = 0;

try
{
    Write("Digite la altura del rectangulo: \t\t");
    alturaRectangulo = double.Parse(ReadLine());

    Write("Digite la base del rectangulo: \t\t\t");
    baseRectangulo = double.Parse(ReadLine());

    Write("Digite el valor de radio: \t\t\t");
    radio = double.Parse(ReadLine());

    Write("Digite el valor de la base del triangulo: \t");
    baseTriangulo = double.Parse(ReadLine());

    Write("Digite el valor de la altura del triangulo: \t");
    alturaTriangulo = double.Parse(ReadLine());
}
catch (FormatException ex) {
    WriteLine("El valor introducido no es un valor correcto, porfavor ingrese un valor valido.");
    WriteLine(ex.Message);
}
catch (Exception e)
{
    WriteLine(e.ToString());
}

Rectangulo rectangulo = new Rectangulo(alturaRectangulo, baseRectangulo);
Circulo circulo = new Circulo(radio);
Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo); 

WriteLine($"\nÁrea del rectángulo: \t\t\t\t{rectangulo.CalcularArea()}");
WriteLine($"Área del círculo: \t\t\t\t{circulo.CalcularArea()}");
WriteLine($"Área del triángulo: \t\t\t\t{triangulo.CalcularArea()}");