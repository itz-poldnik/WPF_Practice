using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{

        [Route("api/[controller]")]
        [ApiController]
        public class ProductsController : ControllerBase
        {
            private readonly WarehouseContext _context;

            public ProductsController(WarehouseContext context)
            {
                _context = context;
            }

            // GET: api/products
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Product>>> GetAll()
            {
                return await _context.Products.ToListAsync();
            }

            // GET: api/products/{id}
            [HttpGet("{id}")]
            public async Task<ActionResult<Product>> GetById(int id)
            {
                var product = await _context.Products.FindAsync(id);
                if (product is null)
                    return NotFound();

                return product;
            }

            // POST: api/products
            [HttpPost]
            public async Task<IActionResult> Create(Product product)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetById), new { id = product.IdProduct }, product);
            }
            // PUT: api/products/5
            // The method below will handle the PUT requests
            [HttpPut("{id}")]
            public async Task<IActionResult> PutProduct(int id, Product product)
            {
                if (id != product.IdProduct)
                {
                    return BadRequest();
                }

                _context.Entry(product).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(id))
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

            private bool ProductExists(int id)
            {
                return _context.Products.Any(e => e.IdProduct == id);
            }
            // DELETE: api/products/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteProduct(int id)
            {
                var product = await _context.Products.FindAsync(id);
                if (product == null)
                {
                    return NotFound();
                }

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                return NoContent();
            }


        }

 
}
