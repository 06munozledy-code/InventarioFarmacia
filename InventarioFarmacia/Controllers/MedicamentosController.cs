using Microsoft.AspNetCore.Mvc;

namespace InventarioFarmacia.Controllers
{
    public class MedicamentosController : Controller


    {
        // Acción para mostrar la lista de medicamentos
        public IActionResult Index()
        {
            return View();
        }

        // Acción para crear un nuevo medicamento
        public IActionResult Create()
        {
            return View();
        }
    }
}