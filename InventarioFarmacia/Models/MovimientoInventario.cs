namespace InventarioFarmacia.Models
{
    public class MovimientoInventario
    {
        public int Id { get; set; }
        public int MedicamentoId { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaMovimiento { get; set; }
    }
}
