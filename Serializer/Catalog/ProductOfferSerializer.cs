using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;
using Turbo.WIN63202506020918587581630.Serializer.Catalog.Types;

namespace Turbo.WIN63202506020918587581630.Serializer.Catalog;
public class ProductOfferSerializer() : AbstractSerializer<ProductOfferMessage>(MessageComposer.ProductOfferComposer)
{
    protected override void Serialize(IServerPacket packet, ProductOfferMessage message)
    {
        OfferSerializer.Serialize(packet, message.Offer, true, true);
    }
}
