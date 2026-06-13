using Microsoft.AspNetCore.Mvc;

namespace InventarioFarmacia.Controllers
{
    public class LoteController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Create() => View();
    }
}
