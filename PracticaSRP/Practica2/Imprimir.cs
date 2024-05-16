using Practica2.Entities;
using static System.Console;
namespace Practica2
{
    public class Imprimir : Persona
    {
        public Imprimir(string nombre, int edad, string direccion, string correoElectronico) :base(nombre, edad, direccion, correoElectronico)
        { 
        
        }

        public void ImprimirDatos()
        {
            WriteLine($"Nombre: \t\t{nombre}");
            WriteLine($"Edad: \t\t\t{edad}");
            WriteLine($"Dirección: \t\t{direccion}");
            WriteLine($"Correo electrónico: \t{correoElectronico}");
        }
    }
}
