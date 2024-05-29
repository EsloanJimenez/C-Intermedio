using JustGrill.Domain.Core;

namespace JustGrill.Domain.Entities
{
    public class MenuComida : Menu
    {
        public bool RequiereTermino { get; set; }
        public bool RequiereGuarnicion {  get; set; }
    }
}
