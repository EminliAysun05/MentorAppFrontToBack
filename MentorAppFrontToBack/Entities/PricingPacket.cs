namespace MentorAppFrontToBack.Entities
{
    public class PricingPacket
    {
       public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public int PacketId { get; set; }
        public Packet Packet { get; set; }
    } 
}
