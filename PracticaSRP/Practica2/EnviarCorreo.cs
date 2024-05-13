using Practica2.Entities;
using Practica2.Interfaces;

namespace Practica2
{
    public class EnviarCorreo : ICorreoElectronico
    {
        Persona persona1 = new Persona();
        public void EnviarCorreoElectronico(string mensaje)
        {
            Console.WriteLine($"\n\n{persona1.nombre = "Enrique"} <{persona1.correoElectronico = "EsloanJimenez@gmail.com"}>");
            Console.WriteLine($"{mensaje}");
        }
    }
}
