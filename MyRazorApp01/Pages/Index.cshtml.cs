using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp01.Pages;

public class Index : PageModel
{
    public List<Category> Categories { get; set; } = new();

    public async Task OnGetAsync()
    {
        await Task.Delay(5000);
        
        Categories.Add(new Category(1, "Cat 1"));
        Categories.Add(new Category(2, "Cat 2"));
        Categories.Add(new Category(3, "Cat 3"));
        Categories.Add(new Category(4, "Cat 4"));
    }

    public void OnPost()
    {
    }
}

public record Category(int Id, string Title);