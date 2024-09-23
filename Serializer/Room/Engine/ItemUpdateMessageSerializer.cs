using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.WIN63202407091256704579380.Serializer.room.Types;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class ItemUpdateMessageSerializer() : AbstractSerializer<ItemUpdateMessage>(MessageComposer.ItemUpdateMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ItemUpdateMessage message)
    {
        ItemDataSerializer.Serialize(packet, message.Object);
    }
}