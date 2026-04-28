using Microsoft.AspNetCore.Mvc.RazorPages;
using PALBuildingMaterial.Models;
using PALBuildingMaterial.Services;

namespace PALBuildingMaterial.Pages;

public class ProductsModel : PageModel
{
    private readonly ProductService _productService;

    public List<Product> Products { get; set; } = new();

    public ProductsModel(ProductService productService)
    {
        _productService = productService;
    }

    public void OnGet()
    {
        Products = _productService.GetProducts();
    }
}