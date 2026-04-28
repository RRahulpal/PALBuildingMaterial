using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PALBuildingMaterial.Models;
using PALBuildingMaterial.Services;

namespace PALBuildingMaterial.Pages;

public class CartModel : PageModel
{
    private readonly ProductService _productService;

    public List<Product> CartProducts { get; set; } = new();

    public string ProductNames => string.Join(", ", CartProducts.Select(x => x.Name));

    public CartModel(ProductService productService)
    {
        _productService = productService;
    }

    public void OnGet()
    {
        LoadCart();
    }

    public IActionResult OnGetAdd(int id)
    {
        var cart = GetCart();

        if (!cart.Contains(id))
        {
            cart.Add(id);
        }

        SaveCart(cart);

        return RedirectToPage("/Cart");
    }

    public IActionResult OnGetRemove(int id)
    {
        var cart = GetCart();
        cart.Remove(id);
        SaveCart(cart);

        return RedirectToPage("/Cart");
    }

    public IActionResult OnGetClear()
    {
        SaveCart(new List<int>());
        return RedirectToPage("/Cart");
    }

    private void LoadCart()
    {
        var cart = GetCart();
        CartProducts = _productService.GetProducts()
            .Where(x => cart.Contains(x.Id))
            .ToList();
    }

    private List<int> GetCart()
    {
        var value = HttpContext.Session.GetString("cart");

        if (string.IsNullOrEmpty(value))
            return new List<int>();

        return value.Split(',').Select(int.Parse).ToList();
    }

    private void SaveCart(List<int> cart)
    {
        HttpContext.Session.SetString("cart", string.Join(",", cart));
    }
}