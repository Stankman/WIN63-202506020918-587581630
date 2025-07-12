using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Tracking;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Tracking;

public class PingMessageSerializer() : AbstractSerializer<PingMessage>(MessageComposer.PingMessageComposer)
{
    protected override void Serialize(IServerPacket packet, PingMessage message)
    {
    }
}