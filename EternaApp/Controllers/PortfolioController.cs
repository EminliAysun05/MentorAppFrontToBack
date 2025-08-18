using EternaApp.Data;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly EternaAppDbContext _eternaAppDbContext;

        public PortfolioController(EternaAppDbContext eternaAppDbContext)
        {
            _eternaAppDbContext = eternaAppDbContext;
        }

        public IActionResult Index()
        {
            PortfolioVm portfolioVm = new()
            {
                Categories = _eternaAppDbContext.Categories.ToList(),
                Portfolios = _eternaAppDbContext.Portfolios
                .Include(p => p.PortfolioImages)
                .ToList()
            };

            return View(portfolioVm);
        }

        public IActionResult Detail(int id)
        {
            var portfolio = _eternaAppDbContext.Portfolios
                .Include(p => p.Category)
                .Include(p => p.PortfolioImages)
                .FirstOrDefault(p => p.Id == id);
            if (portfolio == null)
                return NotFound();
            return View(portfolio);
        }
    }
}
