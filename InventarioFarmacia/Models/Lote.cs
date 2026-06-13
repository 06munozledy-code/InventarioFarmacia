namespace InventarioFarmacia.Models
{
    public class Lote
    {
        public int Id { get; set; }
        public string CodigoLote { get; set; } = string.Empty;
        public DateTime FechaVencimiento { get; set; }
    }
}
