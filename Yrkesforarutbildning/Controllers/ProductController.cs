using Infrastructure.Context;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Yrkesforarutbildning.Models;


namespace Yrkesforarutbildning.Controllers;

public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

 


    [Route("/Tjänster")]
    public IActionResult Services()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Offer(string? service)
    {
        var model = new OfferModel
        {
            SelectedService = service
        };

        return View(model);

    }

    [HttpPost]
    public IActionResult Offer(OfferModel model)
    {
        if (ModelState.IsValid)
        {
            var offerEntity = new OfferEntity
            {
                SelectedService = model.SelectedService,
                FirstName = model.FirstName,
                LastName = model.LastName,
                OrgNumber = model.OrgNumber,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                CreatedAt = DateTime.UtcNow

            };

            _context.Offers.Add(offerEntity);
            _context.SaveChanges();
            return RedirectToAction("Index" , "Home");

        }
        return View();

    }

}