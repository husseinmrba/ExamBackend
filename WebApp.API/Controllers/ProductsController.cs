using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebApp.API.DataAccess;
using WebApp.API.Models;
using WebApp.API.Models.ViewModels;

namespace WebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Product>> GetPruducts()
        {
            var products = ProductDataStore.Current.Products;
            return Ok(products);
        }

        [HttpGet("{productId}", Name = "GetProductById")]
        public ActionResult<Product> GetProductById(int productId)
        {
            var product = ProductDataStore.Current.Products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct(ProductForCreation product)
        {
            var lastExistingProductId = ProductDataStore.Current.Products.Max(p => p.Id);
            var productToBeAdded = new Product() {
                Id = ++lastExistingProductId,
                Name = product.Name,
                Price = product.Price
            };
            ProductDataStore.Current.Products.Add(productToBeAdded);

            return CreatedAtRoute("GetProductById",
                                   new { productId = productToBeAdded.Id },
                                   productToBeAdded
            );
        }

        [HttpPut("{productId}")]
        public ActionResult UpdateProduct(int productId, ProductForUpdate product)
        {
            var existingProduct = ProductDataStore.Current.Products.FirstOrDefault(p => p.Id == productId);
            if (existingProduct == null)
                return NotFound();
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            return NoContent();
        }
        
        // Download Microsoft.AspNetCore.JsonPath
        // Download Microsoft.AspNetCore.Mvc.NewtonsoftJson
        [HttpPatch("{productId}")]
        public ActionResult PartiallyUpdateProduct(int productId, JsonPatchDocument<ProductForUpdate> patchDocument)
        {
            var existingProduct = ProductDataStore.Current.Products.FirstOrDefault(p => p.Id == productId);
            if (existingProduct == null)
                return NotFound();
            var productToPatch = new ProductForUpdate()
            {
                Name = existingProduct.Name,
                Price = existingProduct.Price
            };
            patchDocument.ApplyTo(productToPatch);
            existingProduct.Name = productToPatch.Name;
            existingProduct.Price = productToPatch.Price;
            return NoContent();
        }

        [HttpDelete("{productId}")]
        public ActionResult DeleteProduct(int productId)
        {
            var existingProduct = ProductDataStore.Current.Products.FirstOrDefault(p => p.Id == productId);
            if (existingProduct == null)
                return NotFound();
            ProductDataStore.Current.Products.Remove(existingProduct);
            return NoContent();
        }

    }
}
