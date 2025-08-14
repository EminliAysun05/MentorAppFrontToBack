using MentorAppFrontToBack.Data;
using MentorAppFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorAppFrontToBack.Controllers;

	public class HomeController : Controller
{
    private readonly MentorAppDb _context;

    public HomeController(MentorAppDb context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var heroes = await _context.Heroes.FirstOrDefaultAsync();

        if(heroes is null)
            return NotFound("no hero found");
        HomeVm homeVm = new HomeVm
        {
            Hero = heroes,
            WhyUs = await _context.WhyUs.ToListAsync(),
            Services = await _context.Services.ToListAsync()
        };
        
        return View(homeVm);
    }

    
}
