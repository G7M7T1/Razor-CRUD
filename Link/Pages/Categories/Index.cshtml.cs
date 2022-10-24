using Link.Data;
using Link.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Link.Pages.Categories;

public class Index : PageModel
{
    private readonly ApplicationDbContext _db;
    
    public IEnumerable<Category> Categories { get; set; }

    public Index(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        Categories = _db.Category;
    }
}