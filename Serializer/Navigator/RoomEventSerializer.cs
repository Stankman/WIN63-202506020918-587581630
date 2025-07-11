using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class RoomEventSerializer() : AbstractSerializer<RoomEventMessage>(MessageComposer.RoomEventComposer)
{
    protected override void Serialize(IServerPacket packet, RoomEventMessage message)
    {
        packet.WriteInteger(-1); //Room Event ID
        packet.WriteInteger(-1); //Owner ID
        packet.WriteString(""); //Owner Name
        packet.WriteInteger(-1); //Room ID
        packet.WriteInteger(-1); //Room Type ID
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(-1);
    }
}
