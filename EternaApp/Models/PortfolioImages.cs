using EternaApp.Entities.Common;

namespace EternaApp.Models
{
    public class PortfolioImages : BaseEntity
    {
        public string ImageUrl { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
