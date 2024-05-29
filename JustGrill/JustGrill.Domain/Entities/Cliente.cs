using JustGrill.Domain.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JustGrill.Domain.Entities
{
    [Table("", Schema ="")]
    public sealed class Cliente : Persona
    {
        public int ClienteID { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
    }
}


