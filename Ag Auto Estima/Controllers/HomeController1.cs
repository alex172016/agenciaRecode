using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ag_Auto_Estima.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Promocao()
        {
            return View();
        }

        public IActionResult Destino()
        {
            return View();
        }


    }
}
