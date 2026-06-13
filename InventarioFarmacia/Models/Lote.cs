using System;

namespace InventarioFarmacia.Models
{
    internal class Lote
    {
        public int Id { get; set; }
        public string NumeroLote { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}