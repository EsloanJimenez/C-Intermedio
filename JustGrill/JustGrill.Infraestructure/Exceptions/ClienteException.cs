namespace JustGrill.Infraestructure.Exceptions
{
    public class ClienteException : Exception
    {
        public ClienteException(string message) : base(message)
        {
            // Logica para enviar el correo y loggear el error.
        }
    }
}
