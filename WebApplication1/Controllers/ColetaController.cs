using System;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Data;
using AutoMapper;
using WebApplication1.Services;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColetaController : Controller
    {
        private readonly IColetaService _coletaService;
        private readonly IMapper _mapper;
        private List<ColetaModel> _coleta;

        public ColetaController(IMapper mapper, IColetaService coletaService)
        {
            _mapper = mapper;
            _coleta = GerarColetas();
            _coletaService = coletaService;
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

            TempData["mensagemSucesso"] = "Cliente cadastrado com sucesso";

            return RedirectToAction(nameof(Index));
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
