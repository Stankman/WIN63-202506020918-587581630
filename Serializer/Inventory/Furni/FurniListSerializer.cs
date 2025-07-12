using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Serializers;
using Turbo.WIN63202506020918587581630.Serializer.Inventory.Furni.Types;

namespace Turbo.WIN63202506020918587581630.Serializer.Inventory.Furni;
public class FurniListSerializer() : AbstractSerializer<FurniListMessage>(MessageComposer.FurniListComposer)
{
    protected override void Serialize(IServerPacket packet, FurniListMessage message)
    {
        packet.WriteInteger(message.TotalFragments);
        packet.WriteInteger(message.CurrentFragment);
        packet.WriteInteger(message.Furniture.Count);

        foreach (var furni in message.Furniture)
        {
            FurniDataSerializer.Serialize(packet, furni);
        }
    }
}
