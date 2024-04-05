using Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Suggestify.Pages;

public class IndexModel : PageModel
{

    [BindProperty]
    public Parameter Parameter { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
      Parameter = new Parameter();
    }

    public IActionResult OnPost()
    {
        Console.WriteLine(Parameter.Message);
        return RedirectToPage("/Index");
    }

}
