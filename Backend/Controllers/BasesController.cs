using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniLoginBack.Models;

namespace UniLoginBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasesController : ControllerBase
    {
        private readonly UNIDB001Context _context;

        public BasesController(UNIDB001Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Unitb004Base> GetUnitb004Base()
        {
            return _context.Unitb004Base;
        }

        // GET: api/Bases/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUnitb004Base([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unitb004Base = await _context.Unitb004Base.FindAsync(id);

            if (unitb004Base == null)
            {
                return NotFound();
            }

            return Ok(unitb004Base);
        }

        // PUT: api/Bases/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnitb004Base([FromRoute] int id, [FromBody] Unitb004Base unitb004Base)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != unitb004Base.CoBase)
            {
                return BadRequest();
            }

            _context.Entry(unitb004Base).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Unitb004BaseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> PostUnitb004Base([FromBody] Unitb004Base unitb004Base)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Unitb004Base.Add(unitb004Base);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUnitb004Base", new { id = unitb004Base.CoBase }, unitb004Base);
        }

        // DELETE: api/Bases/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnitb004Base([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unitb004Base = await _context.Unitb004Base.FindAsync(id);
            if (unitb004Base == null)
            {
                return NotFound();
            }

            _context.Unitb004Base.Remove(unitb004Base);
            await _context.SaveChangesAsync();

            return Ok(unitb004Base);
        }

        private bool Unitb004BaseExists(int id)
        {
            return _context.Unitb004Base.Any(e => e.CoBase == id);
        }
    }
}