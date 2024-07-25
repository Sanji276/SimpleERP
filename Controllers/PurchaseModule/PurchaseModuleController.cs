using Microsoft.AspNetCore.Mvc;

namespace SimpleERP.Controllers.PurchaseModule
{
    public class PurchaseModuleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
