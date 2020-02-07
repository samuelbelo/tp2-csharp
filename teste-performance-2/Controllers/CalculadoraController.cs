using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using teste_performance_2.Services;
using teste_performance_2.Models;

namespace teste_performance_2.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly CalculadoraService _calculadoraService;
        public CalculadoraController()
        {
            _calculadoraService = new CalculadoraService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Soma(SomaModel somaModel)
        {
            ViewBag.Title = "Soma";

            var result = _calculadoraService.EfetuaSoma(somaModel);
            somaModel.result = result;

            return View("Result", somaModel);
        }



    
    }
}