using EternaApp.Entities;
using EternaApp.Models;

namespace EternaApp.ViewModels;

public class HomeVm
{
    public List<Slider> Sliders { get; set; }
    public List<Client> Clients { get; set; }
    public List<ClientLogoImages> ClientLogoImages { get; set; }
}
