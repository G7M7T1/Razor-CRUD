using Link.Data;
using Link.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Link.Pages.Categories;

public class Delete : PageModel
{
    private readonly ApplicationDbContext _db;
    [BindProperty]
    public Category Category { get; set; }
    
    public Delete(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public IActionResult OnGet(int id)
    {
        Category = _db.Category.Find(id);

        if (!ModelState.IsValid) return Page();
        _db.Category.Remove(Category);
        _db.SaveChanges();
        return RedirectToPage("Index");
    }

    // public async Task<IActionResult> OnPost()
    // {
    //     if (Category.Name == Category.DisplayOrder.ToString())
    //     {
    //         ModelState.AddModelError("Category.Name", "The name cannot match the display order");
    //     }
    //     
    //     if (ModelState.IsValid)
    //     {
    //         _db.Category.Update(Category);
    //         await _db.SaveChangesAsync();
    //         return RedirectToPage("Index");
    //     }
    //
    //     return Page();
    // }
    
}