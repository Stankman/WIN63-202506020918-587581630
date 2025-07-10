using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Catalog.Marketplace;
public class MarketplaceConfigurationSerializer() : AbstractSerializer<MarketplaceConfigurationMessage>(MessageComposer.MarketplaceConfigurationComposer)
{
    protected override void Serialize(IServerPacket packet, MarketplaceConfigurationMessage message)
    {
        packet.WriteBoolean(true);
        packet.WriteInteger(1); //Comision Percentage.
        packet.WriteInteger(0); //Credits
        packet.WriteInteger(0); //Advertisements
        packet.WriteInteger(2); //Min Price
        packet.WriteInteger(10); //Max Price
        packet.WriteInteger(168); //Hours in Marketplace
        packet.WriteInteger(7); //Days to Display
        packet.WriteInteger(2); //Selling Fee Percentage | unknkown atm 2 by default
        packet.WriteInteger(100000); //Revenue Limit
        packet.WriteInteger(400000); //Half Tax Limit
    }
}
