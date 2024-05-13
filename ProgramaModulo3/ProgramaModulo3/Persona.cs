using ProgramaModulo3.Interface;

namespace ProgramaModulo3
{
    public class Persona : IViendoInformacion
    {
        private string _nombre;
        private int _edad;

        public string Nombre
        {
            get => _nombre; set => _nombre = value;
        }
        public int Edad
        {
            get => _edad; set => _edad = value;
        }

        public void VerInfo()
        {
            Console.WriteLine($"""
                Nombre: {Nombre}
                Edad:   {Edad}
                """);
        }
    }
}
