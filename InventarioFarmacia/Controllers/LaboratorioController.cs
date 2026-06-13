using Microsoft.AspNetCore.Mvc;

namespace InventarioFarmacia.Controllers
{
    public class LaboratorioController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Create() => View();
    }
}