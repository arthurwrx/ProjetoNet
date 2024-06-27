using System;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace WebApplication1.Controllers
{
    public class ColetaController : Controller
    {
        private List<ColetaModel> _coleta;

        public ColetaController()
        {
            _coleta = GerarColetas();
        }

        public IActionResult Index()
        {
            return View(_coleta);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ColetaModel coletaModel)
        {
            return View();
        }

        private List<ColetaModel> GerarColetas()
        {
            var coletas = new List<ColetaModel>();

            for (int i = 1; i <= 5; i++)
            {
                var coleta = new ColetaModel
                {
                    Bairro = "Nome Bairro" + i,
                    TipoColeta = "Reciclável" + i,
                    DataHora = DateTime.Now
                };

                coletas.Add(coleta);
            }

            return coletas;
        }
    }
}
