using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MInhaViagem.Controllers
{
    public class ProdutoController : Controller
    {
        public async Task<IActionResult> Index(int ID)
        {
            return View();
        }
    }
}