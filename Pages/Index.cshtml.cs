using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TPIntroRazor.Pages
{
    public class IndexModel : PageModel
    {
        public string MessageAccueil { get; set; } = string.Empty;
        public List<string> Modules { get; set; } = new();

        public void OnGet()
        {
            MessageAccueil = "Bienvenue dans le TP Razor Pages !";
            Modules = new List<string>
            {
                "Structure d'un projet Razor Pages",
                "Syntaxe Razor (@)",
                "Code-behind et PageModel",
                "Formulaires et [BindProperty]"
            };
        }
    }
}