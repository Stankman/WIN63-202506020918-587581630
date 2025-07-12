using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;
using Turbo.WIN63202506020918587581630.Serializer.room.Types;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class ItemUpdateMessageSerializer() : AbstractSerializer<ItemUpdateMessage>(MessageComposer.ItemUpdateMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ItemUpdateMessage message)
    {
        ItemDataSerializer.Serialize(packet, message.Object);
    }
}