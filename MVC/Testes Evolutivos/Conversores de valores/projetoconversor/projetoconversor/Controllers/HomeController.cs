using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projetosoma.Models;
using System.Diagnostics;

namespace projetosoma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _log;

        public HomeController(ILogger<HomeController> log)
        {
            _log = log;
        }

        public IActionResult ConverterMedida(double valorMetros, string unidade)
        {
            double resultado = 0;

            switch (unidade.ToLower())
            {
                case "centimetro":
                    resultado = valorMetros * 100;
                    break;
                case "milimetro":
                    resultado = valorMetros * 1000;
                    break;
                case "quilometro":
                    resultado = valorMetros / 1000;
                    break;
                case "pé":
                    resultado = valorMetros * 3.28084;
                    break;
                case "milha":
                    resultado = valorMetros / 1609.34;
                    break;
                default:
                    resultado = valorMetros;
                    break;
            }

            ResultadoViewModel resultadoView = new ResultadoViewModel
            {
                ValorMetros = valorMetros,
                Unidade = unidade,
                Resultado = resultado
            };

            return View("Index", resultadoView); 
        }

        public IActionResult Index()
        {
            return View(new ResultadoViewModel());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
