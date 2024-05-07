using Practica2.Interfaces;
using static System.Console;

namespace Practica2
{
    public class Imprimir : ICorreoElectronico
    {
        Persona persona1 = new Persona("Enrique", 30, "Sagrario Diaz", "EsloanJimenez@gmail.com");

        public void EnviarCorreoElectronico(string mensaje)
        {

            WriteLine($"\n\n{persona1.getNombre()} <{persona1.getCorreoElectronico()}>");
            WriteLine($"{mensaje}");
        }

        public void ImprimirDatos()
        {
            WriteLine($"Nombre: \t\t{persona1.getNombre()}");
            WriteLine($"Edad: \t\t\t{persona1.getEdad()}");
            WriteLine($"Dirección: \t\t{persona1.getDireccion()}");
            WriteLine($"Correo electrónico: \t{persona1.getCorreoElectronico()}");
        }
    }
}
