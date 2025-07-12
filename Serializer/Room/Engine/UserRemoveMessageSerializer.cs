using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class UserRemoveMessageSerializer() : AbstractSerializer<UserRemoveMessage>(MessageComposer.UserRemoveMessageComposer)
{
    protected override void Serialize(IServerPacket packet, UserRemoveMessage message)
    {
        packet.WriteString(message.Id.ToString());
    }
}