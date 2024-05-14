using Practica2.Entities;
using Practica2.Interfaces;

namespace Practica2
{
    public class EnviarCorreo : Persona, ICorreoElectronico
    {
        public EnviarCorreo(string nombre, int edad, string direccion, string correoElectronico) : base(nombre, edad, direccion, correoElectronico)
        {

        }
        public void EnviarCorreoElectronico(string mensaje)
        {
            Console.WriteLine($"\n\n{nombre} <{correoElectronico}>");
            Console.WriteLine($"{mensaje}");
        }
    }
}
