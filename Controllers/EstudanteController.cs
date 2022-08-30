using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    // private static List<EstudanteViewModel> estudantes = 
    //     new List<EstudanteViewModel>();
    private static List<EstudanteViewModel> estudantes = 
        new List<EstudanteViewModel> {
            new EstudanteViewModel(1, "Dany Gomes", "Rua V, 1", true),
            new EstudanteViewModel(2, "Lidi Reis", "Rua G, 3", true),
            new EstudanteViewModel(3, "Sah Marques", "Rua J, 7", false),
            new EstudanteViewModel(4, "Viny Ferreira", "Rua D, 8", true),
            new EstudanteViewModel(5, "Gus Macedo", "Rua L, 5", false)
        };
    public IActionResult Index()
    {
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}