using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookShop.Models;
using OnlineBookStoreRazor.Data;

namespace OnlineBookStoreRazor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            Category  = _db.Categories.Find(id);
        }
        public IActionResult OnPost(Category obj) 
        {
            _db.Categories.Update(Category);
            _db.SaveChanges();
            TempData["success"] = "Category edited successfully";
            return RedirectToPage("Index");
        }
    }
}
