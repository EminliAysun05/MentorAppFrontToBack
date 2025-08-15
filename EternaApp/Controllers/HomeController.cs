using EternaApp.Data;
using EternaApp.Migrations;
using EternaApp.Models;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EternaApp.Controllers;

public class HomeController : Controller
{
    private readonly EternaAppDbContext _eternaAppDbContext;

    public HomeController(EternaAppDbContext eternaAppDbContext)
    {
       _eternaAppDbContext = eternaAppDbContext;
    }

    public async Task<IActionResult> Index()
    {
        var vm = new HomeVm
        {
            Sliders = await _eternaAppDbContext.Sliders.ToListAsync()
        };

        return View(vm);
    }

   
}
