using BaltaShop.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BaltaShop.Pages.Backoffice
{
    public class IndexModel : PageModel
    {
        private readonly BaltaShop.Data.AppDbContext _context;

        public IndexModel(BaltaShop.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
