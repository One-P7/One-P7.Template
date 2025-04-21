using Microsoft.AspNetCore.Mvc;
using ThreeLayer.Service.Interfaces;
using ThreeLayer.WebApi.Controllers.ViewModel;

namespace ThreeLayer.WebApi.Controllers;

/// <summary>
/// ctor
/// </summary>
/// <param name="productService"></param>
[Route("api/[controller]")]
[ApiController]
public class ProductController(IProductService productService) : ControllerBase
{

    /// <summary>
    /// 取得產品資訊
    /// </summary>
    /// <returns></returns>
    [HttpGet("{id:int}")]
    public IActionResult GetProductInfoAsync([FromRoute] int id)
    {
        var dto = productService.GetById(id);

        var viewModel = new ProductViewModel
        {
            ProductId = dto.ProductId,
            ProductName = dto.Name,
            Price = dto.ListPrice,
            IsDiscontinued = true,
        };

        return this.Ok(viewModel);
    }
}
