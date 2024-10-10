using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculadoraPotencial.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraPotencial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _log;
        public HomeController(ILogger<HomeController> log) => _log = log;
        public IActionResult CalculaPotencia(double baseNum, double expoente)
        {
            double resultado = Math.Pow(baseNum, expoente);
            ViewBag.Resultado = resultado;
            return View("Index");
        }

        public IActionResult Index() => View();

        public IActionResult Privacy() => View();

        // Para que o cache das respostas não fique armazenado em local algum
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
