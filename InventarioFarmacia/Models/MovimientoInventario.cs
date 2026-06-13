using System;

namespace InventarioFarmacia.Models
{
    internal class MovimientoInventario
    {
        public int Id { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
    }
}