using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiComBancoDeDados.Models;

namespace WebApiComBancoDeDados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrosController : ControllerBase
    {
        private readonly BancoDeDadosInnerJoinContext _context;

        public CarrosController(BancoDeDadosInnerJoinContext context)
        {
            _context = context;
        }

        // GET: api/Carros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carros>>> GetCarros()
        {
            return await _context.Carros.ToListAsync();
        }

        // GET: api/Carros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carros>> GetCarros(int id)
        {
            var carros = await _context.Carros.FindAsync(id);

            if (carros == null)
            {
                return NotFound();
            }

            return carros;
        }

        // PUT: api/Carros/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarros(int id, Carros carros)
        {
            if (id != carros.Id)
            {
                return BadRequest();
            }

            _context.Entry(carros).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrosExists(id))
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

        // POST: api/Carros
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Carros>> PostCarros(Carros carros)
        {
            _context.Carros.Add(carros);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarros", new { id = carros.Id }, carros);
        }

        // DELETE: api/Carros/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Carros>> DeleteCarros(int id)
        {
            var carros = await _context.Carros.FindAsync(id);
            if (carros == null)
            {
                return NotFound();
            }

            _context.Carros.Remove(carros);
            await _context.SaveChangesAsync();

            return carros;
        }

        private bool CarrosExists(int id)
        {
            return _context.Carros.Any(e => e.Id == id);
        }
    }
}
