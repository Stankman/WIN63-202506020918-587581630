using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Availability;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Availability;

public class AvailabilityStatusMessageSerializer()
    : AbstractSerializer<AvailabilityStatusMessage>(MessageComposer.AvailabilityStatusMessageComposer)
{
    protected override void Serialize(IServerPacket packet, AvailabilityStatusMessage message)
    {
        packet
            .WriteBoolean(message.IsOpen)
            .WriteBoolean(message.OnShutDown)
            .WriteBoolean(message.IsAuthenticHabbo);
    }
}