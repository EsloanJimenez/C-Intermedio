namespace JustGrill.Domain.Core
{
    public class Persona : EntidadConNombre
    {
        protected Persona() { 
            this.CreationDate = DateTime.Now;
            this.Deleted = false;
        }
        public DateTime StartDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
