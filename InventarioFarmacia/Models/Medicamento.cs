namespace InventarioFarmacia.Models
{
    public class Medicamento
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public DateTime FechaVencimiento { get; set; }

    public bool EstaProximoAVencer => FechaVencimiento <= DateTime.Now.AddDays(30);
    public bool TieneStockCritico => Stock <= 5;
}
}