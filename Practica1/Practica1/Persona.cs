namespace Practica1
{
    public class Persona
    {
        private string? _nombre;
        private int? _edad;
        private string? _ciudad;

        public Persona(string? nombre, int? edad, string? ciudad)
        {
            _nombre = nombre;
            _edad = edad;
            _ciudad = ciudad;
        }

        public virtual void getInfo() { 
            Console.WriteLine($"Nombre: \t {_nombre} \nEdad: \t\t {_edad} años \nCiudad: \t {_ciudad}");
        }

        public void setCalculaEdad(int edad)
        {
            _edad= edad;
        }
    }
}
