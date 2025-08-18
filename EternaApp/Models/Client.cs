using EternaApp.Entities.Common;
using System.Reflection.Metadata.Ecma335;

namespace EternaApp.Models
{
    public class Client : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<ClientLogoImages> ClientLogoImages { get; set; }
    }
}
