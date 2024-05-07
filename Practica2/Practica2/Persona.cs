namespace Practica2
{
    public class Persona
    {

        private string _nombre;
        private int _edad;
        private string _direccion;
        private string _correoElectronico;

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            _nombre = nombre;
            _edad = edad;
            _direccion = direccion;
            _correoElectronico = correoElectronico;
        }

        public string getNombre() => _nombre;
        public int getEdad() => _edad;
        public string getDireccion() => _direccion;
        public string getCorreoElectronico() => _correoElectronico;

    }
}
