using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Notifications;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Notifications;

public class InfoFeedEnableMessageSerializer() : AbstractSerializer<InfoFeedEnableMessage>(MessageComposer.InfoFeedEnableMessageComposer)
{
    protected override void Serialize(IServerPacket packet, InfoFeedEnableMessage message)
    {
        packet.WriteBoolean(message.Enabled);
    }
}