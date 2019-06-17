using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Interface.Services;

namespace MirumTeste.UI.Web.Controllers
{
    public class CargosController : Controller
    {
        private readonly ICargoServices _cargoService;
        private readonly ICargoPessoaServices _cargoPessoaService;
        public CargosController(ICargoServices cargoService, ICargoPessoaServices cargoPessoaServices)
        {
            _cargoService = cargoService;
            _cargoPessoaService = cargoPessoaServices;
        }

        public IActionResult Index()
        {
            return View(_cargoService.ObterTodos());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Funcao, SalarioBase")] Cargo cargo)
        {
            
            if (ModelState.IsValid)
            {
                _cargoService.Adicionar(cargo);
                return RedirectToAction(nameof(Index));
            }
            return View(cargo);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                ModelState.AddModelError("", "id não informado");
            }

            var cargo = _cargoService.ObterUnico(id);
            if (cargo == null)
            {
                ModelState.AddModelError("", "Cargo não encontrado");
            }
            return View(cargo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id, Funcao, SalarioBase")] Cargo cargo)
        {
            if (id != cargo.Id)
            {
                ModelState.AddModelError("", "Id não informado");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _cargoService.Atualizar(cargo);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CargoExists(cargo.Id))
                    {
                        ModelState.AddModelError("", "Cargo não encontrado");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cargo);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                ModelState.AddModelError("", "Id não informado");
            }

            var cargo = _cargoService.ObterUnico(id);
            if (cargo == null)
            {
                ModelState.AddModelError("", "Cargo não encontrado");
            }

            return View(cargo);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ModelState.AddModelError("", "Id não informado");
            }

            var cargo = _cargoService.ObterUnico(id);
            if (cargo == null)
            {
                ModelState.AddModelError("", "Cargo não encontrado");
            }

            return View(cargo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cargo = _cargoService.ObterUnico(id);
            _cargoService.Remover(cargo);
            return RedirectToAction(nameof(Index));
        }

        private bool CargoExists(int id)
        {
            return _cargoService.ObterUnico(id) != null;
        }
    }
}