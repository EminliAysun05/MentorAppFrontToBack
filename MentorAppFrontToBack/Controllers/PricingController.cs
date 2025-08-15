using MentorAppFrontToBack.Data;
using MentorAppFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorAppFrontToBack.Controllers;

public class PricingController : Controller
{
    private readonly MentorAppDb _mentorAppDb;

    public PricingController(MentorAppDb mentorAppDb)
    {
        _mentorAppDb = mentorAppDb;
    }

    public IActionResult Index()
    {
        var pricings = _mentorAppDb.Pricings.
            Include(p => p.PricingPackets)
            .ThenInclude(pp => pp.Packet)
            .ToList();
        var packets = _mentorAppDb.Packets.ToList();
        var pricingVm = new PricingVm
        {
            Pricings = pricings,
            Packets = packets,
        };
        return View(pricingVm);
    }
}
