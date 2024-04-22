using Models;
using Services.ChatGPT;
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
        Parameter = new();
    }

    public void OnGet()
    {
        _logger.LogInformation("OnGet");
    }

    public async Task<IActionResult> OnPost()
    {

        OpenAIClient openAIClient= new();
        string? prompt = Parameter.Message;
        string? response = await openAIClient.GetResponse(prompt);
        if (response != null)
            _logger.LogInformation(response);
        else
            _logger.LogWarning("No response");

        return RedirectToPage("/Index");
    }
}