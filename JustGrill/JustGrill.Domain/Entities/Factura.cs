﻿using JustGrill.Domain.Core;

namespace JustGrill.Domain.Entities
{
    public class Factura : AuditoriaEntities
    {
        public int FacturaID { get; set; }
        public int PedidoID { get; set; }
    }
}
