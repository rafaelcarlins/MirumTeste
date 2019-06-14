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

        public PessoasController(IPessoaServices pessoaService)
        {
            _pessoaService = pessoaService;
        }
        public IActionResult Index()
        {
            return View(_pessoaService.ObterTodos());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Nome,Rg,Email")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _pessoaService.Adicionar(pessoa);
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }


        // GET: Contatos/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = _pessoaService.ObterUnico(id);
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
        public IActionResult Edit(int id, [Bind("Id, Nome, Rg, Email")] Pessoa pessoa)
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
                    if (!ContatoExists(pessoa.Id))
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
            return View(pessoa);
        }


        // GET: Contatos/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = _pessoaService.ObterUnico(id);
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

            var contato = _pessoaService.ObterUnico(id);
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
            var contato = _pessoaService.ObterUnico(id);
            _pessoaService.Remover(contato);
            return RedirectToAction(nameof(Index));
        }


        private bool ContatoExists(int id)
        {
            return _pessoaService.ObterUnico(id) != null;
        }
    }
}
