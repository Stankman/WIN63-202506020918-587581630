using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.WIN63202407091256704579380.Serializer.Inventory.Furni.Types;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class ObjectDataUpdateMessageSerializer() : AbstractSerializer<ObjectDataUpdateMessage>(MessageComposer.ObjectDataUpdateMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ObjectDataUpdateMessage message)
    {
        packet.WriteString(message.Object.Id.ToString());

        StuffDataSerializer.SerializeStuffData(packet, message.Object);
    }
}