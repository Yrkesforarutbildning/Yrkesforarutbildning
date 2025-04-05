using Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Yrkesforarutbildning.Models;

namespace Yrkesforarutbildning.Controllers;

public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }


    [Route("/AdminPortal")]
    public IActionResult AdminPortal()
    {
        var offers = _context.Offers
        .Select(o => new OfferModel
        {
            Id = o.Id,
            ChooseDate = o.ChooseDate,
            SelectedService = o.SelectedService,
            FirstName = o.FirstName,
            LastName = o.LastName,
            Address = o.Address,
            PhoneNumber = o.PhoneNumber,
            Email = o.Email,
            CreatedAt = o.CreatedAt,


        })
        .ToList(); 

        return View(offers);

    }


    [HttpPost]
    public IActionResult Delete(int id)
    {
        var booking = _context.Offers.FirstOrDefault(x => x.Id == id);
        if (booking != null)
        {
            _context.Offers.Remove(booking);
            _context.SaveChanges();
        }

        return RedirectToAction("AdminPortal");
    }

    [Route("/AdminLogin")]
    public IActionResult AdminLogin()
    {
        return View();
    }
}
