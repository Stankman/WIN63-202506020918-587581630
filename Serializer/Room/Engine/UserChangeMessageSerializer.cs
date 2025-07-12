using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class UserChangeMessageSerializer() : AbstractSerializer<UserChangeMessage>(MessageComposer.UserChangeMessageComposer)
{
    protected override void Serialize(IServerPacket packet, UserChangeMessage message)
    {
        packet.WriteInteger(message.Id);
        packet.WriteString(message.Figure);
        packet.WriteString(message.Sex);
        packet.WriteString(message.CustomInfo);
        packet.WriteInteger(message.ActivityPoints);
    }
}