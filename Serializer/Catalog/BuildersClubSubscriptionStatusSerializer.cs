using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Catalog;
public class BuildersClubSubscriptionStatusSerializer() : AbstractSerializer<BuildersClubSubscriptionStatusMessage>(MessageComposer.BuildersClubSubscriptionStatusMessageComposer)
{
    protected override void Serialize(IServerPacket packet, BuildersClubSubscriptionStatusMessage message)
    {
        packet.WriteInteger(0);
        packet.WriteInteger(50);
        packet.WriteInteger(2000000);
        packet.WriteInteger(0);
    }
}
