using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Competition;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Competition;

public class CurrentTimingCodeMessageSerializer()
    : AbstractSerializer<CurrentTimingCodeMessage>(MessageComposer.CurrentTimingCodeMessageComposer)
{
    protected override void Serialize(IServerPacket packet, CurrentTimingCodeMessage message)
    {
        packet.WriteString(message.SchedulingStr)
            .WriteString(message.Code);
    }
}