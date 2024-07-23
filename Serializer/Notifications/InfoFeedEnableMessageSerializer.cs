using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Notifications;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Notifications;

public class InfoFeedEnableMessageSerializer() : AbstractSerializer<InfoFeedEnableMessage>(MessageComposer.InfoFeedEnableMessageComposer)
{
    protected override void Serialize(IServerPacket packet, InfoFeedEnableMessage message)
    {
        packet.WriteBoolean(message.Enabled);
    }
}