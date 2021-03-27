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
    public class CompraController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompraController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Compra
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Compra.Include(c => c.Cliente);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Compra/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra
                .Include(c => c.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }

        // GET: Compra/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id");
            return View();
        }

        // POST: Compra/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DataCompra,QtdeCotas,StatusCompra,ClienteId,Id,DataCadastro,DataAtualizacao,UserUpdate")] Compra compra)
        {
            if (ModelState.IsValid)
            {
                compra.Id = Guid.NewGuid();
                _context.Add(compra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id", compra.ClienteId);
            return View(compra);
        }

        // GET: Compra/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra.FindAsync(id);
            if (compra == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id", compra.ClienteId);
            return View(compra);
        }

        // POST: Compra/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("DataCompra,QtdeCotas,StatusCompra,ClienteId,Id,DataCadastro,DataAtualizacao,UserUpdate")] Compra compra)
        {
            if (id != compra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompraExists(compra.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Id", compra.ClienteId);
            return View(compra);
        }

        // GET: Compra/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compra
                .Include(c => c.Cliente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }

        // POST: Compra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var compra = await _context.Compra.FindAsync(id);
            _context.Compra.Remove(compra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompraExists(Guid id)
        {
            return _context.Compra.Any(e => e.Id == id);
        }
    }
}
