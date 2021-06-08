using CatalogueService.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatalogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly DBContext context;
        public CatalogController(DBContext ctx)
        {
            context = ctx;
        }
        // GET: api/<CatalogController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            return await context.Products.ToListAsync();
        }

        // GET api/<CatalogController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await context.Products.FindAsync(id);
            if (product == null) return NotFound();

            return product ;
        }

        // POST api/<CatalogController>
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct( Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }

        // PUT api/<CatalogController>/5
        //[HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ProductId) return BadRequest();

            context.Entry(product).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (!ProductExists(id)) return NotFound();
                else throw;

            }

            return NoContent();
        }


        //// DELETE api/<CatalogController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await context.Products.FindAsync(id);
            if (product == null) return NotFound();
              
            return product;
        }

        private bool ProductExists(int id)
        {
            return context.Products.Any(e => e.ProductId == id);
        }

    }
}
