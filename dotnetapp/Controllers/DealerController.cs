using System;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;

namespace dotnetapp.Controllers;


public class DealerController:Controller

{
    private readonly ApplicationDbContext context;

    public DealerController(ApplicationDbContext _context)
    {
        context=_context; 
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Delete(int ID)
    {
        return View();
    }
    // public IActionResult Edit()
    // {
    //     return View();
    // }
    //  [HttpPost]
    //  public IActionResult Create(Dealer dealer)
    // {
    //     var data
        
    //     return View();
    // }
    // public IActionResult Description()
    // {
    //     return View();
    // }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Dealer dealer)
    {
        if(ModelState.IsValid)
        {
            context.Dealers.Add(dealer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }
  
}