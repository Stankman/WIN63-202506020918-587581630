using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Permissions;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Room.Permissions;

public class YouAreOwnerSerializer() : AbstractSerializer<YouAreOwnerMessage>(MessageComposer.YouAreOwnerMessageComposer)
{
    protected override void Serialize(IServerPacket packet, YouAreOwnerMessage message)
    {
        packet.WriteInteger(message.RoomId);
    }
}