using MentorAppFrontToBack.Entities;

namespace MentorAppFrontToBack.ViewModels
{
    public class HomeVm
    {
        public Hero Hero { get; set; }
        public List<WhyUs> WhyUs { get; set; }
        public List<Service> Services { get; set; }
    }
}
