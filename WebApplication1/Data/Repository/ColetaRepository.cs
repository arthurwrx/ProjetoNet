using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Data.Repository
{
    public class RepresetanteRepository : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
