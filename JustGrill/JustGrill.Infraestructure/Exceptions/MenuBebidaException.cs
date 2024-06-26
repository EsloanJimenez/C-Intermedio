namespace JustGrill.Infraestructure.Exceptions
{
    public class MenuBebidaException : Exception
    {
        public MenuBebidaException(string message) : base(message)
        {
            // Logica para enviar el correo y loggear el error.
        }
    }
}
