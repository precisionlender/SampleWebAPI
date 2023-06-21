using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Models;

namespace SampleWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
  private static readonly List<Product> Products = new()
    {
        new Product
        {
            Id = 0,
            Name = "Red Truck",
            Description = "A red truck"
        },
        new Products
        {
            Id = 1,
            Name = "Blue Car",
            Description = "A blue car"
        },
        new Product
        {
            Id = 2,
            Name = "Toaster",
            Description = "It doesn't drive, but it toasts"
        },
        new Product
        {
            Id = 3,
            Name = "Waffle iron",
            Description = "It doesn't toast, but makes delicious waffles"
        }
        new Product
        {
            Id = 4,
            Name = "Pasta Maker",
            Description = "It doesn't toast, but make a killer spagetti"
        }
    };

  private static Product Find(int id)
  {
    return Products.Find(e => e.Id == id);
  }

  // GET: api/Product
  [HttpGet]
  public IEnumerable<Product> Get()
  {
    return Products;
  }

  // GET: api/Product/5
  [HttpGet("{id}")]
  [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public IActionResult Get(int id)
  {
    var product = Find(id);
    return product == null ? NotFound() : Ok(product);
  }
}
