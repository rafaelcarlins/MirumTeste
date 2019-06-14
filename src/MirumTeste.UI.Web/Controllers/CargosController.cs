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

        public CargosController(ICargoServices cargoService)
        {
            _cargoService = cargoService;
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


        // GET: Contatos/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = _cargoService.ObterUnico(id);
            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        // POST: Contatos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id, Funcao, SalarioBase")] Cargo cargo)
        {
            if (id != cargo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _cargoService.Atualizar(cargo);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContatoExists(cargo.Id))
                    {
                        return NotFound();
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


        // GET: Contatos/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = _cargoService.ObterUnico(id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }


        // GET: Contatos/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = _cargoService.ObterUnico(id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }

        // POST: Contatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var contato = _cargoService.ObterUnico(id);
            _cargoService.Remover(contato);
            return RedirectToAction(nameof(Index));
        }


        private bool ContatoExists(int id)
        {
            return _cargoService.ObterUnico(id) != null;
        }
    }
}