using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Outgoing.Tracking;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Tracking;

public class LatencyPingRequestMessageSerializer() : AbstractSerializer<LatencyPingResponseMessage>(MessageComposer.LatencyPingRequestMessageComposer)
{
    protected override void Serialize(IServerPacket packet, LatencyPingResponseMessage message)
    {
        packet.WriteInteger(message.ID);
    }
}