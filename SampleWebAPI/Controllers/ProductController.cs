using System.Collections.Generic;
using System.Web.Http;
using SampleWebAPI.Models;

namespace SampleWebAPI.Controllers
{
    public class ProductController : ApiController
    {
        private static readonly List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 0,
                Name = "Red Truck",
                Description = "A red truck"
            },
            new Product
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
            },
			new Product
            {
                Id = 4,
                Name = "Pasta Maker",
                Description = "It doesn't toast, but make a killer spagetti"
            }
        };

        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            return Products;
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            return Products[id];
        }
    }
}
