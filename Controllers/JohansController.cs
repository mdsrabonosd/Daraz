using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using daraz.Data;
using daraz.Datamodel;

namespace daraz.Controllers
{
    public class JohansController : Controller
    {
        private readonly darazContext _context;

        public JohansController(darazContext context)
        {
            _context = context;
        }

        // GET: Johans
        public async Task<IActionResult> Index()
        {
              return _context.Johan != null ? 
                          View(await _context.Johan.ToListAsync()) :
                          Problem("Entity set 'darazContext.Johan'  is null.");
        }
       

        // GET: Johans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Johan == null)
            {
                return NotFound();
            }

            var johan = await _context.Johan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (johan == null)
            {
                return NotFound();
            }

            return View(johan);
        }

        // GET: Johans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Johans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Author")] Johan johan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(johan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(johan);
        }

        // GET: Johans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Johan == null)
            {
                return NotFound();
            }

            var johan = await _context.Johan.FindAsync(id);
            if (johan == null)
            {
                return NotFound();
            }
            return View(johan);
        }

        // POST: Johans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Author")] Johan johan)
        {
            if (id != johan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(johan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JohanExists(johan.Id))
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
            return View(johan);
        }

        // GET: Johans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Johan == null)
            {
                return NotFound();
            }

            var johan = await _context.Johan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (johan == null)
            {
                return NotFound();
            }

            return View(johan);
        }

        // POST: Johans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Johan == null)
            {
                return Problem("Entity set 'darazContext.Johan'  is null.");
            }
            var johan = await _context.Johan.FindAsync(id);
            if (johan != null)
            {
                _context.Johan.Remove(johan);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JohanExists(int id)
        {
          return (_context.Johan?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
