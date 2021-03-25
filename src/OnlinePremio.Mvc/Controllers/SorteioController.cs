using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlinePremio.Mvc.Data;
using OnlinePremios.Domain.Entities;

namespace OnlinePremio.Mvc.Controllers
{
    public class SorteioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SorteioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sorteio
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sorteio.ToListAsync());
        }

        // GET: Sorteio/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sorteio = await _context.Sorteio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sorteio == null)
            {
                return NotFound();
            }

            return View(sorteio);
        }

        // GET: Sorteio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sorteio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Numero,DataInicial,DataSorteio,QtdeCotas,ValorCotas,StatusSorteio,Id,DataCadastro,DataAtualizacao,UserUpdate")] Sorteio sorteio)
        {
            if (ModelState.IsValid)
            {
                sorteio.Id = Guid.NewGuid();
                _context.Add(sorteio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }
            return View(sorteio);
        }

        // GET: Sorteio/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sorteio = await _context.Sorteio.FindAsync(id);
            if (sorteio == null)
            {
                return NotFound();
            }
            return View(sorteio);
        }

        // POST: Sorteio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Numero,DataInicial,DataSorteio,QtdeCotas,ValorCotas,StatusSorteio,Id,DataCadastro,DataAtualizacao,UserUpdate")] Sorteio sorteio)
        {
            if (id != sorteio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sorteio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SorteioExists(sorteio.Id))
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
            return View(sorteio);
        }

        // GET: Sorteio/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sorteio = await _context.Sorteio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sorteio == null)
            {
                return NotFound();
            }

            return View(sorteio);
        }

        // POST: Sorteio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sorteio = await _context.Sorteio.FindAsync(id);
            _context.Sorteio.Remove(sorteio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SorteioExists(Guid id)
        {
            return _context.Sorteio.Any(e => e.Id == id);
        }
    }
}
