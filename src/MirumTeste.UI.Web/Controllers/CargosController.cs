using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MirumTeste.ApplicationCore.Interface.Services;

namespace MirumTeste.UI.Web.Controllers
{
    public class CargosController : Controller
    {
        private readonly ICargoServices _cargoService;

        public CargosController(ICargoServices cargoService)
        {
            _cargoService = cargoService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}