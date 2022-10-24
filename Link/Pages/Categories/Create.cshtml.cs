using Link.Data;
using Link.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Link.Pages.Categories;

// [BindProperties]
public class Create : PageModel
{
    private readonly ApplicationDbContext _db;
    
    [BindProperty]
    public Category Category { get; set; }

    public Create(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void OnGet()
    {
        
    }

    public async Task<IActionResult> OnPost()
    {
        if (Category.Name == Category.DisplayOrder.ToString())
        {
            ModelState.AddModelError("Category.Name", "The name cannot match the display order");
        }
        
        if (ModelState.IsValid)
        {
            await _db.Category.AddAsync(Category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }

        return Page();
    }
}