using BaltaShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BaltaShop.Pages.Backoffice;

public class CreateModel : PageModel
{
    private readonly BaltaShop.Data.AppDbContext _context;

    public CreateModel(BaltaShop.Data.AppDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public Product Product { get; set; } = default!;
        

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid || _context.Products == null || Product == null)
            return Page();

        _context.Products.Add(Product);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}