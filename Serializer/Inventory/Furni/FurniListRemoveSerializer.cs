using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Inventory.Furni;

internal class FurniListRemoveSerializer() : AbstractSerializer<FurniListRemoveMessage>(MessageComposer.FurniListRemoveComposer)
{
    protected override void Serialize(IServerPacket packet, FurniListRemoveMessage message)
    {
        packet.WriteInteger(message.ItemId);
    }
}
