using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ProductAPI
{
    [ApiController]
    [Route("api/[controller]")] // Route de base 'api/product'
    public class ProductController : ControllerBase
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Nom = "Chaise", Prix = 199 },
            new Product { Id = 2, Nom = "Table", Prix = 299 }
        };

        // Endpoint pour ajouter un produit (POST)
        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Le produit est requis.");
            }
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // Endpoint pour récupérer un produit par son ID (GET)
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // Endpoint pour récupérer tous les produits (GET)
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_products);
        }
    }
}
