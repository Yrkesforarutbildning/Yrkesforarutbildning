using Microsoft.AspNetCore.Mvc;

namespace Yrkesforarutbildning.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [Route("/OmOss")]
    public IActionResult AboutUs()
    {
        return View();
    }

    [Route("/Kontakt")]
    public IActionResult Contact()
    {
        return View();
    }
}
