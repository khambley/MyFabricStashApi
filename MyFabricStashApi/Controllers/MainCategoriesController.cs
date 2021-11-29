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
    public class MainCategoriesController : ControllerBase
    {
        private readonly MyFabricStashContext _context;

        public MainCategoriesController(MyFabricStashContext context)
        {
            _context = context;
        }

        // GET: api/MainCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainCategory>>> GetMainCategory()
        {
            return await _context.MainCategories.ToListAsync();
        }

        // GET: api/MainCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainCategory>> GetMainCategory(long id)
        {
            var mainCategory = await _context.MainCategories.FindAsync(id);

            if (mainCategory == null)
            {
                return NotFound();
            }

            return mainCategory;
        }

        // PUT: api/MainCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMainCategory(long id, MainCategory mainCategory)
        {
            if (id != mainCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(mainCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainCategoryExists(id))
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

        // POST: api/MainCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MainCategory>> PostMainCategory(MainCategory mainCategory)
        {
            _context.MainCategories.Add(mainCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMainCategory", new { id = mainCategory.Id }, mainCategory);
        }

        // DELETE: api/MainCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMainCategory(long id)
        {
            var mainCategory = await _context.MainCategories.FindAsync(id);
            if (mainCategory == null)
            {
                return NotFound();
            }

            _context.MainCategories.Remove(mainCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MainCategoryExists(long id)
        {
            return _context.MainCategories.Any(e => e.Id == id);
        }
    }
}
