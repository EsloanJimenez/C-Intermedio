namespace Practica2.Entities
{
    public class Persona
    {

        public string nombre { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public string correoElectronico { get; set; }

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }
    }
}
