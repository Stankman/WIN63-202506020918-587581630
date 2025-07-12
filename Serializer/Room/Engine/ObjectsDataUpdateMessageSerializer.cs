using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.WIN63202506020918587581630.Serializer.Inventory.Furni.Types;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class ObjectsDataUpdateMessageSerializer() : AbstractSerializer<ObjectsDataUpdateMessage>(MessageComposer.ObjectsDataUpdateMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ObjectsDataUpdateMessage message)
    {
        packet.WriteInteger(message.Objects.Count);

        foreach (var floorObject in message.Objects)
        {
            packet.WriteInteger(floorObject.Id);

            StuffDataSerializer.SerializeStuffData(packet, floorObject);
        }
    }
}