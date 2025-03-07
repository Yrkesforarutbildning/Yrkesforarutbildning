using Microsoft.AspNetCore.Mvc;

namespace Yrkesforarutbildning.Controllers;

public class AdminController : Controller
{
    [Route("/AdminPortal")]
    public IActionResult AdminPortal()
    {
        return View();
    }

    [Route("/AdminLogin")]
    public IActionResult AdminLogin()
    {
        return View();
    }
}
