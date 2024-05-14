namespace CSIPJR.Domain
{
    public abstract class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Phone {  get; set; }
        public string? Email { get; set; }

        public abstract void Save();
        public virtual void Load()
        {
            Console.WriteLine("Cargando los datos...");
        }
    }

    public interface IBaseEmployee
    {
        public DateTime? HireDate { get; set; }
    }
    public class Student : Person
    {
        public override void Save()
        {
            Console.WriteLine("Guardando la informacion del estudiante.");
        }
    }

    public class Instructor : Person, IBaseEmployee
    {
        public DateTime? HireDate { get; set; }

        public override void Save() {
            Console.WriteLine("Guardando la informacion del instructor.");
        }
        public override void Load()
        {
            Console.WriteLine("Cargando la informacion del instructor.");
        }
    }

    public class Employee : Person, IBaseEmployee
    {
        public DateTime? HireDate { get; set; }
        public override void Save()
        {
            Console.WriteLine("Guardando la informacion del empleado.");
        }
    }
}
