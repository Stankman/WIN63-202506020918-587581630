using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class ItemRemoveMessageSerializer() : AbstractSerializer<ItemRemoveMessage>(MessageComposer.ItemRemoveMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ItemRemoveMessage message)
    {
        packet.WriteString(message.ItemId.ToString());
        packet.WriteInteger(message.PickerId);
    }
}