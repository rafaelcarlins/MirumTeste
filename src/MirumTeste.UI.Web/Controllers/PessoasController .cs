using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Interface.Repository;
using MirumTeste.ApplicationCore.Interface.Services;
using MirumTeste.Infra.Data;

namespace MirumTeste.UI.Web.Controllers
{
    public class PessoasController : Controller
    {
        private readonly IPessoaServices _pessoaService;
        private readonly ICargoServices _cargoService;
        private readonly ICargoPessoaServices _cargoPessoaService;

        public PessoasController(IPessoaServices pessoaService, ICargoServices cargoService, ICargoPessoaServices cargoPessoaService)
        {
            _pessoaService = pessoaService;
            _cargoService = cargoService;
            _cargoPessoaService = cargoPessoaService;
        }

        public IActionResult List()
        {
            return View(_cargoPessoaService.ObterTodosComCargos());
        }

        public IActionResult Index()
        {

            ViewData["Cargos"] = _cargoPessoaService.ObterTodosComCargos();
            return View(_pessoaService.ObterTodos());
        }
        public IActionResult Create()
        {
            ViewData["Cargos"] = _cargoService.ObterTodos();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Nome,Rg,Email, CargoId")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _pessoaService.Adicionar(pessoa);
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                ModelState.AddModelError("", "Id não informado");
            }

            var cargo = _pessoaService.ObterUnico(id);
            if (cargo == null)
            {
                ModelState.AddModelError("", "Pessoa não encontrada");
            }
            ViewData["Cargos"] = _cargoService.ObterTodos();
            return View(cargo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id, Nome, Rg, Email, CargoId")] Pessoa pessoa)
        {
            if (id != pessoa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _pessoaService.Atualizar(pessoa);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!cargoExists(pessoa.Id))
                    {
                        ModelState.AddModelError("", "Pessoa não encontrada");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                ModelState.AddModelError("", "Id não informado");
            }

            var cargo = _pessoaService.ObterUnico(id);
            if (cargo == null)
            {
                ModelState.AddModelError("", "Pessoa não encontrada");
            }

            return View(cargo);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ModelState.AddModelError("", "Id não informado");
            }

            var cargo = _pessoaService.ObterUnico(id);
            if (cargo == null)
            {
                ModelState.AddModelError("", "Pessoa não encontrada");
            }

            return View(cargo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cargo = _pessoaService.ObterUnico(id);
            _pessoaService.Remover(cargo);
            return RedirectToAction(nameof(Index));
        }

        private bool cargoExists(int id)
        {
            return _pessoaService.ObterUnico(id) != null;
        }
    }
}
