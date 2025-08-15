using EternaApp.Entities.Common;

namespace EternaApp.Entities
{
    public class Slider : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
        public string ImageUrl { get; set; }
    }
}
