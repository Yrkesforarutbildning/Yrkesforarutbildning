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
            ChooseDate = o.ChooseDate,
            SelectedService = o.SelectedService,
            FirstName = o.FirstName,
            LastName = o.LastName,
            Address = o.Address,
            PhoneNumber = o.PhoneNumber,
            Email = o.Email,

        })
        .ToList(); 

        return View(offers);

    }


    [HttpPost]
    [ValidateAntiForgeryToken] 
    public IActionResult DeleteOffer(int id)
    {
        
        var offer = _context.Offers.Find(id);

        if (offer == null)
        {
            return NotFound();
        }

        _context.Offers.Remove(offer);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    [Route("/AdminLogin")]
    public IActionResult AdminLogin()
    {
        return View();
    }
}
