using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFabricStashApi.Data;
using MyFabricStashApi.Models;

namespace MyFabricStashApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FabricsController : ControllerBase
    {
        private readonly MyFabricStashContext _context;

        public FabricsController(MyFabricStashContext context)
        {
            _context = context;
        }

        // GET: api/Fabrics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fabric>>> GetFabric()
        {
            return await _context.Fabrics.ToListAsync();
        }

        // GET: api/Fabrics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fabric>> GetFabric(int id)
        {
            var fabric = await _context.Fabrics.FindAsync(id);

            if (fabric == null)
            {
                return NotFound();
            }

            return fabric;
        }

        // PUT: api/Fabrics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFabric(int id, Fabric fabric)
        {
            if (id != fabric.Id)
            {
                return BadRequest();
            }

            _context.Entry(fabric).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FabricExists(id))
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

        // POST: api/Fabrics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fabric>> PostFabric(Fabric fabric)
        {
            _context.Fabrics.Add(fabric);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFabric", new { id = fabric.Id }, fabric);
        }

        // DELETE: api/Fabrics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFabric(int id)
        {
            var fabric = await _context.Fabrics.FindAsync(id);
            if (fabric == null)
            {
                return NotFound();
            }

            _context.Fabrics.Remove(fabric);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FabricExists(int id)
        {
            return _context.Fabrics.Any(e => e.Id == id);
        }
    }
}
