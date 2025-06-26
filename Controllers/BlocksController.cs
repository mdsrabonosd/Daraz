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
    public class BlocksController : Controller
    {
        private readonly darazContext _context;

        public BlocksController(darazContext context)
        {
            _context = context;
        }

        // GET: Blocks
        public async Task<IActionResult> Index()
        {
              return _context.Block != null ? 
                          View(await _context.Block.ToListAsync()) :
                          Problem("Entity set 'darazContext.Block'  is null.");
        }

        public IActionResult section()
        {
            int number, number2 ;

             number = 10;
             number2 = 1;

            string a = "akash";
            string b = "ariful";
            string ab = a +"_"+ b;
            int sum = number + number2;
            
            ViewBag.Msg ="This data come from controller";
            ViewBag.Sum = sum;

            ViewData["firotech"] = "Hi, Iam viewdata";


            return View();
        }
       


        // GET: Blocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Block == null)
            {
                return NotFound();
            }

            var block = await _context.Block
                .FirstOrDefaultAsync(m => m.Block_ID == id);
            if (block == null)
            {
                return NotFound();
            }

            return View(block);
        }


        // GET: Blocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Block_ID,Block_Name,Block_Address,Block_Number,Feedback,Suggestions")] Block block)
        {
            if (ModelState.IsValid)
            {
                _context.Add(block);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(block);
        }

        // GET: Blocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Block == null)
            {
                return NotFound();
            }

            var block = await _context.Block.FindAsync(id);
            if (block == null)
            {
                return NotFound();
            }
            return View(block);
        }

        // POST: Blocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Block_ID,Block_Name,Block_Address,Block_Number,Feedback,Suggestions")] Block block)
        {
            if (id != block.Block_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(block);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlockExists(block.Block_ID))
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
            return View(block);
        }

        // GET: Blocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Block == null)
            {
                return NotFound();
            }

            var block = await _context.Block
                .FirstOrDefaultAsync(m => m.Block_ID == id);
            if (block == null)
            {
                return NotFound();
            }

            return View(block);
        }

        // POST: Blocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Block == null)
            {
                return Problem("Entity set 'darazContext.Block'  is null.");
            }
            var block = await _context.Block.FindAsync(id);
            if (block != null)
            {
                _context.Block.Remove(block);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlockExists(int id)
        {
          return (_context.Block?.Any(e => e.Block_ID == id)).GetValueOrDefault();
        }
    }
}
