using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Catalog;
public class PurchaseErrorSerializer() : AbstractSerializer<PurchaseErrorMessage>(MessageComposer.PurchaseErrorMessageComposer)
{
    protected override void Serialize(IServerPacket packet, PurchaseErrorMessage message)
    {
        packet.WriteInteger((int) message.ErrorCode);
    }
}
