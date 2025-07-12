using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class ItemDataUpdateMessageSerializer() : AbstractSerializer<ItemDataUpdateMessage>(MessageComposer.ItemDataUpdateMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ItemDataUpdateMessage message)
    {
        packet.WriteString(message.ItemId.ToString());
        packet.WriteString(message.ItemData);
    }
}