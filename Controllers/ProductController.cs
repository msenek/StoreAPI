using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;
using TestAPI.Models;
using TestAPI.DTOs;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly TestApiContext _context;

        public ProductController(TestApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Create(ProductRequestDTO request)
        {
            var product = new Product
            {
                ProductName = request.ProductName,
                ProductDescription = request.ProductDescription,
                ProductStatus = request.ProductStatus
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductRequestDTO request)
        {
            var product = _context.Products.Find(id);

            if (product == null)
                return NotFound();

            product.ProductName = request.ProductName;
            product.ProductDescription = request.ProductDescription;
            product.ProductStatus = request.ProductStatus;

            _context.SaveChanges();

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok();
        }
    }
}
