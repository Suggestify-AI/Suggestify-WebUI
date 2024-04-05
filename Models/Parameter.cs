using Microsoft.AspNetCore.Mvc;

namespace Models;

public class Parameter
{
    [BindProperty]
    public string? Message { get; set; }
}