using EternaApp.Data;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            Sliders = await _eternaAppDbContext.Sliders.ToListAsync(),
            Clients = await _eternaAppDbContext.Clients.ToListAsync(),
            ClientLogoImages = await _eternaAppDbContext.ClientLogoImages.ToListAsync()
        };

        return View(vm);
    }

   
}
