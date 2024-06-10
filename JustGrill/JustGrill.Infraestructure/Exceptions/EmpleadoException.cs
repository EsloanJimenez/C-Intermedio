namespace JustGrill.Infraestructure.Exceptions
{
    public class EmpleadoException : Exception
    {
        public EmpleadoException(string message) : base(message)
        {
            // Logica para enviar el correo y loggear el error.
        }
    }
}
