using EternaApp.Entities.Common;

namespace EternaApp.Models;

public class Portfolio : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Client { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<PortfolioImages> PortfolioImages { get; set; }
}
