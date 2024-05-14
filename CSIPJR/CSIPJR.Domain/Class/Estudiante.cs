namespace CSIPJR.Domain.Class
{
    public class Estudiante : Persona
    {
        public override int ObtenerEdad(DateTime fechaNac)
        {
            var edad = DateTime.Now.Year - fechaNac.Year;
            return edad;
        }
    }
}
