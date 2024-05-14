namespace CSIPJR.Domain.Class
{
    public abstract class Persona
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        //public abstract int ObtenerEdad(DateTime fechaNac);

        public virtual int ObtenerEdad(DateTime fechaNac)
        {
            var edad = DateTime.Now.Year - fechaNac.Year;
            return edad;
        }
    }
}
