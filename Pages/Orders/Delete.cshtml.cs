using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;
    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Order Order { get; set; }

    public void OnGet(int id)
    {
        Order = _context.Orders.Find(id);
    }

    public IActionResult OnPost()
    {


        _context.Orders.Remove(Order);
        _context.SaveChanges();
        // Redirect to Page
        return RedirectToPage("Index");
    }

}