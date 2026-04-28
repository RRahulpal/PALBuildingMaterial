using PALBuildingMaterial.Models;

namespace PALBuildingMaterial.Services;

public class ProductService
{
    public List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Cement",
                Description = "Premium cement for strong construction.",
                Price = "Best Market Price",
                Image = "/Images/cement.png",
                Category = "Cement"
            },
            new Product
            {
                Id = 2,
                Name = "Sand",
                Description = "Fine river and crushed sand.",
                Price = "Available Per Brass",
                Image = "/Images/sand.png",
                Category = "Sand"
            },
            new Product
            {
                Id = 3,
                Name = "Bricks",
                Description = "Strong red bricks and blocks.",
                Price = "Available Per Piece",
                Image = "/images/brick.png",
                Category = "Bricks"
            },
            new Product
            {
                Id = 10,
                Name = "Khadi / Aggregate",
                Description = "Crushed stone (khadi) used for RCC, concrete and construction work.",
                Price = "Available Per Brass / Ton",
                Image = "/images/aggregate.png",
                Category = "Aggregate"
            },
            new Product
            {
                Id = 5,
                Name = "Steel",
                Description = "TMT steel bars for RCC work.",
                Price = "Available Per Kg",
                Image = "/images/steel.png",
                Category = "Steel"
            },
            new Product
            {
                Id = 6,
                Name = "Tiles",
                Description = "Floor and wall tiles.",
                Price = "Available Per Box",
                Image = "/images/tiles.png",
                Category = "Tiles"
            },
            new Product
            {
                Id = 7,
                Name = "Plumbing",
                Description = "Pipes, taps and fittings.",
                Price = "Contact for Quote",
                Image = "/images/plumbing.png",
                Category = "Plumbing"
            },
            new Product
            {
                Id = 8,
                Name = "Electrical",
                Description = "Wires, switches and boards.",
                Price = "Contact for Quote",
                Image = "/images/electrical.png",
                Category = "Electrical"
            },
          
            new Product
            {
                Id = 9,
                Name = "Hardware",
                Description = "Tools, nails, screws and fittings.",
                Price = "Contact for Quote",
                Image = "/images/hardware.png",
                Category = "Hardware"
            }
        };
    }
}