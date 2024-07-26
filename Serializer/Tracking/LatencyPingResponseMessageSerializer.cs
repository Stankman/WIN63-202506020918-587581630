using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Tracking;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Tracking;

public class LatencyPingResponseMessageSerializer() : AbstractSerializer<LatencyPingResponseMessage>(MessageComposer.LatencyPingResponseMessageComposer)
{
    protected override void Serialize(IServerPacket packet, LatencyPingResponseMessage message)
    {
        packet.WriteInteger(message.ID);
    }
}