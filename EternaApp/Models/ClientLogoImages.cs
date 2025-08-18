using EternaApp.Entities.Common;

namespace EternaApp.Models
{
    public class ClientLogoImages : BaseEntity
    {
        public string ImageUrl { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
    }
}
