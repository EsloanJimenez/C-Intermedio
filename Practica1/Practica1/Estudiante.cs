namespace Practica1
{
    public class Estudiante : Persona
    {
        private string _carrera;
        private int _matricula;

        public Estudiante(string nombre, int edad, string ciudad, string carrera, int matricula) : base(nombre, edad, ciudad)
        {
            _carrera = carrera;
            _matricula = matricula;
        }

        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine($"Carrera: \t {_carrera} \nMatricula: \t {_matricula}");
        }
    }
}
