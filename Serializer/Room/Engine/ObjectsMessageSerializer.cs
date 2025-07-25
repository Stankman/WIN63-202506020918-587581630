using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.WIN63202506020918587581630.Serializer.room.Types;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class ObjectsMessageSerializer() : AbstractSerializer<ObjectsMessage>(MessageComposer.ObjectsMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ObjectsMessage message)
    {
        packet.WriteInteger(message.OwnersIdToUsername.Count);

        foreach (var entry in message.OwnersIdToUsername)
        {
            packet.WriteInteger(entry.Key);
            packet.WriteString(entry.Value);
        }

        packet.WriteInteger(message.Objects.Count);

        foreach (var obj in message.Objects)
        {
            ObjectDataSerializer.Serialize(packet, obj);
        }
    }
}