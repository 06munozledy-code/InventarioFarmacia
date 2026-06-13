using InventarioFarmacia.Models;

namespace InventarioFarmacia.Repositories
{
    public interface IMedicamentoRepository
    {
        Task<IEnumerable<Medicamento>> GetAllAsync();
        Task AddAsync(Medicamento medicamento);
    }
}
