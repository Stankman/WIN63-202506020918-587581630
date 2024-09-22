using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Catalog;
public class BonusRareInfoSerializer() : AbstractSerializer<BonusRareInfoMessage>(MessageComposer.BonusRareInfoMessageComposer)
{
    protected override void Serialize(IServerPacket packet, BonusRareInfoMessage message)
    {
        packet.WriteString("prizetrophy_breed_gold");
        packet.WriteInteger(0);
        packet.WriteInteger(100);
        packet.WriteInteger(100);
    }
}