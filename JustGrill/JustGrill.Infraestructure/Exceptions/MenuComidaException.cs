namespace JustGrill.Infraestructure.Exceptions
{
    public class MenuComidaException : Exception
    {
        public MenuComidaException(string message) : base(message)
        {
            // Logica para enviar el correo y loggear el error.
        }
    }
}
