using InventarioFarmacia.Models;

namespace InventarioFarmacia.Repositories
{
    public class MedicamentoRepository : IMedicamentoRepository
    {
        // conexión a la base de datos 
        public async Task<IEnumerable<Medicamento>> GetAllAsync()
        {
       
            return await Task.FromResult(new List<Medicamento>());
        }

        public async Task AddAsync(Medicamento medicamento)
        {
            // lógica para guardar en base de datos
            await Task.CompletedTask;
        }
    }
}
