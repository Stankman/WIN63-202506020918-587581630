using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Navigator;

public class RoomEventSerializer() : AbstractSerializer<RoomEventMessage>(MessageComposer.RoomEventComposer)
{
    protected override void Serialize(IServerPacket packet, RoomEventMessage message)
    {
        packet.WriteInteger(-1);         // Room Event ID (no event)
        packet.WriteInteger(-1);         // Owner ID (no owner)
        packet.WriteString("");          // Owner name
        packet.WriteInteger(-1);         // Room ID
        packet.WriteInteger(-1);         // Room Type ID
        packet.WriteInteger(0);          // Event start time (epoch or minutes since)
        packet.WriteInteger(0);          // Max participants or something similar
        packet.WriteInteger(0);          // Current participants
        packet.WriteInteger(-1);         // Category ID
    }
}
