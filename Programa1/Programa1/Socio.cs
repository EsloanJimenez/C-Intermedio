namespace Programa1
{
    public class Socio
    {
        private string _nombre;
        private int _antiguedad;

        public Socio(string nombre, int antiguedad)
        {
            _nombre = nombre;
            _antiguedad = antiguedad;
        }

        public string Nombre { get { return _nombre; } }
        public int Antiguedad { get {  return _antiguedad; } }
    }
}
