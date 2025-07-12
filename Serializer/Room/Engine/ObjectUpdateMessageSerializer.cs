using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.WIN63202506020918587581630.Serializer.room.Types;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class ObjectUpdateMessageSerializer() : AbstractSerializer<ObjectUpdateMessage>(MessageComposer.ObjectUpdateMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ObjectUpdateMessage message)
    {
        ObjectDataSerializer.Serialize(packet, message.Object);
    }
}