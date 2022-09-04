namespace RealTimeChat.Models
{
    public class Interaction
    {
        public string FromUser { get; set; } = string.Empty;

        public string ToUser { get; set; } = string.Empty;
    }

    public class MessageInteraction : Interaction
    {
        public List<byte> Message { get; set; } = new List<Byte>();
    }

    public class PublicKeyInteraction : Interaction
    {
        public string PublicKey { get; set; } = string.Empty;
    }

}