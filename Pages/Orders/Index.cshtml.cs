using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace ASPCRUD.Pages.Orders;

public class IndexModel : PageModel
{
    // connect database 
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    // property

    public List<Order> Order { get; set; }

    public void OnGet()
    {
        Order = _context.Orders.ToList();
    }

}