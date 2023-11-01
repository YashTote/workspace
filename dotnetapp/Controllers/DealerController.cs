using System;
using Microsoft.AspNetCore.Mvc;

using dotnetapp.Models;

namespace dotnetapp.Controllers;


public class DealerController:Controller

{
    private readonly Ap
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Delete(int ID)
    {
        return View();
    }
    public IActionResult Edit()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Create(Dealer d)
    {
        
        return View();
    }
    // public IActionResult Description()
    // {
    //     return View();
    // }
  
}