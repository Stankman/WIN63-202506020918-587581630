using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class RoomPropertyMessageSerializer() : AbstractSerializer<RoomPropertyMessage>(MessageComposer.RoomPropertyMessageEvent)
{
    protected override void Serialize(IServerPacket packet, RoomPropertyMessage message)
    {
        packet.WriteString(message.Property)
            .WriteString(message.Value);
    }
}