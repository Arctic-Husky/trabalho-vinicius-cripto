using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrabalhoCriptomoeda.Model;

namespace TrabalhoCriptomoeda
{
    [Route("api/[controller]")]
    [ApiController]
    public class CriptoCoinController : ControllerBase
    {
        private readonly CriptoCoinContext _context;

        public CriptoCoinController(CriptoCoinContext context)
        {
            _context = context;
        }

        // GET: api/CriptoCoin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CriptoCoin>>> GetCriptoCoinItens()
        {
          if (_context.CriptoCoinItens == null)
          {
              return NotFound();
          }
            return await _context.CriptoCoinItens.ToListAsync();
        }

        // GET: api/CriptoCoin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CriptoCoin>> GetCriptoCoin(int id)
        {
          if (_context.CriptoCoinItens == null)
          {
              return NotFound();
          }
          var criptoCoin = await _context.CriptoCoinItens.FindAsync(id);

          if (criptoCoin == null)
          {
              return NotFound();
          }

          return criptoCoin;
        }

        // PUT: api/CriptoCoin/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCriptoCoin(int id, CriptoCoin criptoCoin)
        {
            if (id != criptoCoin.ID)
            {
                return BadRequest();
            }

            _context.Entry(criptoCoin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CriptoCoinExists(id))
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

        // POST: api/CriptoCoin
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CriptoCoin>> PostCriptoCoin(CriptoCoin criptoCoin)
        {
          if (_context.CriptoCoinItens == null)
          {
              return Problem("Entity set 'CriptoCoinContext.CriptoCoinItens'  is null.");
          }
            _context.CriptoCoinItens.Add(criptoCoin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCriptoCoin", new { id = criptoCoin.ID }, criptoCoin);
        }

        // DELETE: api/CriptoCoin/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCriptoCoin(int id)
        {
            if (_context.CriptoCoinItens == null)
            {
                return NotFound();
            }
            var criptoCoin = await _context.CriptoCoinItens.FindAsync(id);
            if (criptoCoin == null)
            {
                return NotFound();
            }

            _context.CriptoCoinItens.Remove(criptoCoin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CriptoCoinExists(int id)
        {
            return (_context.CriptoCoinItens?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
