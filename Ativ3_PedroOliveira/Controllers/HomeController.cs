using Ativ3_PedroOliveira.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Ativ3_PedroOliveira.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error index method");
                throw;
            }
        }

        [HttpGet]
        public IActionResult Servicos()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error servicos method");
                throw;
            }
        }

        [HttpGet]
        public IActionResult Agendamento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agendamento(AgendamentoModel agendamento)
        {
            Dados.Incluir(agendamento);
            return View("Listagem", Dados.Listar());
        }

        [HttpGet]
        public IActionResult Listagem()
        {
            try
            {
                List<AgendamentoModel> dados = Dados.Listar();
                return View(dados);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading list");
                throw;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
