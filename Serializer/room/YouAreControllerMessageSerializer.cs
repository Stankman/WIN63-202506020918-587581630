using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Permissions;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class YouAreControllerMessageSerializer() : AbstractSerializer<YouAreControllerMessage>(MessageComposer.YouAreControllerMessageComposer)
{
    protected override void Serialize(IServerPacket packet, YouAreControllerMessage message)
    {
        packet.WriteInteger(message.RoomId)
            .WriteInteger((int)message.RoomControllerLevel);
    }
}