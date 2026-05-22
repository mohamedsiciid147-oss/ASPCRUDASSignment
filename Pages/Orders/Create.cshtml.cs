using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CreateModel : PageModel
{

    // Connect Database
    private  readonly ApplicationDbContext _context; 
    public CreateModel(ApplicationDbContext context)
    {
        _context =context;
    }
    // Binding Property 
    [BindProperty]
    public string CustomerName { get; set; }
[BindProperty]
    public string ProductName { get; set; }

[BindProperty]
     public int Quantity { get; set; }
        
        public decimal Price { get; set; }
[BindProperty]
    public DateTime? OrderDate { get; set; }

   
   
    public IActionResult OnPost()
    {


        var Orders= new Order
        {
            CustomerName = CustomerName,
            ProductName = ProductName,
            Quantity = Quantity,
            Price = Price,
            OrderDate = OrderDate,
        }; 

        // Save Records
       
        _context.Orders.Add(Orders);
        _context.SaveChanges();
        // Redirect to Page
        return RedirectToPage("Index");
    }
    
}