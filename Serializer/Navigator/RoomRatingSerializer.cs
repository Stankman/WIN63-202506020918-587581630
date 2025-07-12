using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Navigator;

public class RoomRatingSerializer() : AbstractSerializer<RoomRatingMessage>(MessageComposer.RoomRatingComposer)
{
    protected override void Serialize(IServerPacket packet, RoomRatingMessage message)
    {
        packet.WriteInteger(message.CurrentScore);
        packet.WriteBoolean(message.CanRate);
    }
}
