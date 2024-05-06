namespace Programa1
{
    public class Club
    {
        private Socio _socio1;
        private Socio _socio2;
        private Socio _socio3;
        private Socio _socioMasAntiguo;

        public Club(Socio socio1, Socio socio2, Socio socio3)
        {
            _socio1 = socio1;
            _socio2 = socio2;
            _socio3 = socio3;
        }

        public void SocioMasAntiguo()
        {
            _socioMasAntiguo = _socio3;

            if (_socio1.Antiguedad > _socio2.Antiguedad && _socio1.Antiguedad > _socio3.Antiguedad)
                _socioMasAntiguo = _socio1;
            else if (_socio2.Antiguedad > _socio1.Antiguedad && _socio2.Antiguedad > _socio3.Antiguedad)
                _socioMasAntiguo = _socio2;

            Console.WriteLine($"El socio mas antiguo es: {_socioMasAntiguo.Nombre}");
        }
    }
}
