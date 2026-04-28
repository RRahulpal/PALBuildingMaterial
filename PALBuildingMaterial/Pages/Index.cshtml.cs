using Microsoft.AspNetCore.Mvc.RazorPages;
using PALBuildingMaterial.Models;
using PALBuildingMaterial.Services;

namespace PALBuildingMaterial.Pages;

public class IndexModel : PageModel
{
    private readonly ProductService _productService;

    public List<Product> Products { get; set; } = new();

    public IndexModel(ProductService productService)
    {
        _productService = productService;
    }

    public void OnGet()
    {
        Products = _productService.GetProducts();
    }
}