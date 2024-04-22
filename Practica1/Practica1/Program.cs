using Practica1;
using Practica1.ImplementandoPolimorfismo;

//Persona persona = new Persona("Enrique", 30, "Santo Domingo");

//persona.getInfo();

//Estudiante estudiante = new Estudiante("Enrique", 30, "Santo Domingo", "Desarrollo De Software", 144358);

//estudiante.getInfo();

Rectangulo rectangulo = new Rectangulo(8, 3);
Circulo circulo = new Circulo(7);
Triangulo triangulo = new Triangulo(9, 11);

Console.WriteLine($"Área del rectángulo: \t{rectangulo.CalcularArea()}");
Console.WriteLine($"Área del círculo: \t{circulo.CalcularArea()}");
Console.WriteLine($"Área del triángulo: \t{triangulo.CalcularArea()}");