using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Serializers;
using Turbo.WIN63202506020918587581630.Serializer.Inventory.Furni.Types;

namespace Turbo.WIN63202506020918587581630.Serializer.Inventory.Furni;
internal class FurniListAddOrUpdateSerializer() : AbstractSerializer<FurniListAddOrUpdateMessage>(MessageComposer.FurniListAddOrUpdateComposer)
{
    protected override void Serialize(IServerPacket packet, FurniListAddOrUpdateMessage message)
    {
        FurniDataSerializer.Serialize(packet, message.Furniture);
    }
}
