using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrimerRazorPages.Pages;

public class IndexModel : PageModel
{

    public string? NombreUsuario {get; set;}
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnPost(string nombre)
    {
        NombreUsuario = nombre;

    }
}
