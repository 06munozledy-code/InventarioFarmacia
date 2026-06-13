using Microsoft.AspNetCore.Mvc;

namespace InventarioFarmacia.Controllers
{
    public class MovimientoInventarioController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Create() => View();
    }
}
