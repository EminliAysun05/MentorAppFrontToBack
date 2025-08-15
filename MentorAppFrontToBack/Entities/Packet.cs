namespace MentorAppFrontToBack.Entities;

public class Packet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<PricingPacket> PricingPackets { get; set; }
}
