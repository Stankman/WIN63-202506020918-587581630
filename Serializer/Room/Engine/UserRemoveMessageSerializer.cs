using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class UserRemoveMessageSerializer() : AbstractSerializer<UserRemoveMessage>(MessageComposer.UserRemoveMessageComposer)
{
    protected override void Serialize(IServerPacket packet, UserRemoveMessage message)
    {
        packet.WriteString(message.Id.ToString());
    }
}