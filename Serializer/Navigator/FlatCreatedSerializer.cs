using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class FlatCreatedSerializer() : AbstractSerializer<FlatCreatedMessage>(MessageComposer.FlatCreatedComposer)
{
    protected override void Serialize(IServerPacket packet, FlatCreatedMessage message)
    {
        packet.WriteInteger(message.RoomId);
        packet.WriteString(message.RoomName);
    }
}