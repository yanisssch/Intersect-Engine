namespace Intersect.Network.Packets.Client
{

    public class DeathPacket : CerasPacket
    {

        public DeathPacket(bool death)
        {
            Death = death;
        }

        public bool Death { get; set; }

    }

}
