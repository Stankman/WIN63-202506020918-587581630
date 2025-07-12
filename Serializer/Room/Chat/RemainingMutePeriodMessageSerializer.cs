using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Room.Chat;

public class RemainingMutePeriodMessageSerializer() : AbstractSerializer<RemaningMutePeriodMessage>(MessageComposer.RemainingMutePeriodComposer)
{
    protected override void Serialize(IServerPacket packet, RemaningMutePeriodMessage message)
    {
        packet.WriteInteger(message.MuteSecondsRemaining);
    }
}