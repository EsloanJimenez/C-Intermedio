using Practica2.Entities;
using Practica2.Interfaces;
using static System.Console;

namespace Practica2
{
    public class Imprimir : Persona
    {
        Persona persona1 = new Persona();

        public void ImprimirDatos()
        {
            WriteLine($"Nombre: \t\t{persona1.nombre = "Enrique"}");
            WriteLine($"Edad: \t\t\t{persona1.edad = 30}");
            WriteLine($"Dirección: \t\t{persona1.direccion = "Sagrario Diaz"}");
            WriteLine($"Correo electrónico: \t{persona1.correoElectronico = "EsloanJimenez@gmail.com"}");
        }
    }
}
