namespace MentorAppFrontToBack.Entities
{
    public class Hero
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ButtonLink { get; set; }
        public string? ButtonText { get; set; }

    }
}
