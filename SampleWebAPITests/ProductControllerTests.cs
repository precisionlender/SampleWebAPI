using SampleWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Models;
using NUnit.Framework;

namespace ExampleWebAPITest;

[TestFixture]
public class ProductControllerTests
{
  [Test]
  public void Get_NoParams_ReturnsProductList()
  {
    var productController = new ProductController();

    IEnumerable<Product> result = productController.Get();

    Assert.That(result, Is.Not.Null);
    Assert.That(result, Is.Not.Empty);
  }


  [Test]
  public void Get_ValidParam_ReturnsProduct()
  {
    var productController = new ProductController();

    var result = productController.Get(0);
    var okResult = result as OkObjectResult;
    var okResultValue = okResult.Value as Product;

    Assert.That(okResult, Is.Not.Null);
    Assert.Multiple(() =>
    {
      Assert.That(okResultValue.Id, Is.EqualTo(0));
      Assert.That(okResultValue.Name, Is.EqualTo("Red Truck"));
      Assert.That(okResultValue.Description, Is.Not.Null);
    });
  }
}
