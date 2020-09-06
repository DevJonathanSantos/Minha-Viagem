using Microsoft.AspNetCore.Mvc;

namespace MInhaViagem.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}