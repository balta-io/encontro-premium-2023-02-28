using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp01.Pages.Backoffice;

public class ProductsPage : PageModel
{
    public List<Product> Products { get; set; } = new();

    public void OnGet(
        int skip = 0,
        int take = 5)
    {
        Products = GetProducts(skip, take);
    }

    private List<Product> GetProducts(int skip = 0, int take = 5)
    {
        var result = new List<Product>();
        for (var i = 1; i < 100; i++)
        {
            result.Add(new Product(
                i,
                $"Produto {i}",
                i * 13.75M));
        }

        return result.Skip(skip).Take(take).ToList();
    }
}

public record Product(int Id, string Title, decimal Price);