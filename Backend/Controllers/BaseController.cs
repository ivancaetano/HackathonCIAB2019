using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniLoginBack.Models;

namespace UniLoginBack.Controllers
{
    public class BaseController : Controller
    {
        private readonly UNIDB001Context _context;

        public BaseController(UNIDB001Context context)
        {
            _context = context;
        }

        // GET: Base
        public async Task<IActionResult> Index()
        {
            return View(await _context.Unitb004Base.ToListAsync());
        }

        // GET: Base/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitb004Base = await _context.Unitb004Base
                .FirstOrDefaultAsync(m => m.CoBase == id);
            if (unitb004Base == null)
            {
                return NotFound();
            }

            return View(unitb004Base);
        }

        // GET: Base/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Base/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CoBase,NoBase")] Unitb004Base unitb004Base)
        {
            if (ModelState.IsValid)
            {
                _context.Add(unitb004Base);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(unitb004Base);
        }

        // GET: Base/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitb004Base = await _context.Unitb004Base.FindAsync(id);
            if (unitb004Base == null)
            {
                return NotFound();
            }
            return View(unitb004Base);
        }

        // POST: Base/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CoBase,NoBase")] Unitb004Base unitb004Base)
        {
            if (id != unitb004Base.CoBase)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unitb004Base);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Unitb004BaseExists(unitb004Base.CoBase))
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
            return View(unitb004Base);
        }

        // GET: Base/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitb004Base = await _context.Unitb004Base
                .FirstOrDefaultAsync(m => m.CoBase == id);
            if (unitb004Base == null)
            {
                return NotFound();
            }

            return View(unitb004Base);
        }

        // POST: Base/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var unitb004Base = await _context.Unitb004Base.FindAsync(id);
            _context.Unitb004Base.Remove(unitb004Base);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Unitb004BaseExists(int id)
        {
            return _context.Unitb004Base.Any(e => e.CoBase == id);
        }
    }
}
