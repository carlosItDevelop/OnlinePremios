using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlinePremios.Mvc.Data;
using OnlinePremios.Domain.Entities;

namespace OnlinePremios.Mvc.Controllers
{
    public class CotaController : Controller
    {
        //private readonly ApplicationDbContext _context;

        //public CotaController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //// GET: Cota
        //public async Task<IActionResult> Index()
        //{
        //    var applicationDbContext = _context.Cota.Include(c => c.Compra).Include(cli => cli.Compra.Cliente).OrderBy(o => o.Numero);
        //    //var applicationDbContext = _context.Cota.OrderBy(o => o.Numero);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        //// GET: Cota/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var cota = await _context.Cota
        //        .Include(c => c.Sorteio)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (cota == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(cota);
        //}

        //// GET: Cota/Create
        //public IActionResult Create()
        //{
        //    ViewData["CompraId"] = new SelectList(_context.Set<Compra>(), "Id", "Id");
        //    return View();
        //}

        //// POST: Cota/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Numero,Valor,StatusCota,CompraId,Id,DataCadastro,DataAtualizacao,UserUpdate")] Cota cota)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        cota.Id = Guid.NewGuid();
        //        _context.Add(cota);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CompraId"] = new SelectList(_context.Set<Compra>(), "Id", "Id", cota.CompraId);
        //    return View(cota);
        //}

        //// GET: Cota/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var cota = await _context.Cota.FindAsync(id);
        //    if (cota == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["CompraId"] = new SelectList(_context.Set<Compra>(), "Id", "Id", cota.CompraId);
        //    return View(cota);
        //}

        //// POST: Cota/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Numero,Valor,StatusCota,CompraId,Id,DataCadastro,DataAtualizacao,UserUpdate")] Cota cota)
        //{
        //    if (id != cota.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(cota);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CotaExists(cota.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CompraId"] = new SelectList(_context.Set<Compra>(), "Id", "Id", cota.CompraId);
        //    return View(cota);
        //}

        //// GET: Cota/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var cota = await _context.Cota
        //        .Include(c => c.Compra)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (cota == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(cota);
        //}

        //// POST: Cota/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var cota = await _context.Cota.FindAsync(id);
        //    _context.Cota.Remove(cota);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CotaExists(Guid id)
        //{
        //    return _context.Cota.Any(e => e.Id == id);
        //}
    }
}
