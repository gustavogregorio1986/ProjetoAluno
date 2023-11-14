using Microsoft.AspNetCore.Mvc;

namespace ProjetoEstudoALuno.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Consultar()
        {
            return View();
        }
    }
}
