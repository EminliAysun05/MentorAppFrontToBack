namespace MentorAppFrontToBack.Entities
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price  { get; set; }
        public bool IsFutured { get; set; }
        public bool IsAdvanced { get; set; }
        public List<PricingPacket> PricingPackets { get; set; }
    }
}
