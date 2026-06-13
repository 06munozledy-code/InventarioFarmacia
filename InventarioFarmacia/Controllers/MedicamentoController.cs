using Microsoft.AspNetCore.Mvc;

namespace InventarioFarmacia.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}