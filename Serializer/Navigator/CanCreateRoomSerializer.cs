using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Navigator;
public class CanCreateRoomSerializer () : AbstractSerializer<CanCreateRoomMessage>(MessageComposer.CanCreateRoomComposer)
{
    protected override void Serialize(IServerPacket packet, CanCreateRoomMessage message)
    {
        packet.WriteBoolean(message.MaxRoomsReached);
        packet.WriteInteger(message.MaxRooms);
    }
}
