using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class ObjectRemoveMessageSerializer() : AbstractSerializer<ObjectRemoveMessage>(MessageComposer.ObjectRemoveMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ObjectRemoveMessage message)
    {
        packet.WriteString(message.Id.ToString());
        packet.WriteBoolean(message.IsExpired);
        packet.WriteInteger(message.PickerId);
        packet.WriteInteger(message.Delay);
    }
}