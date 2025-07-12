﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Catalog;
public class PurchaseFromCatalogParser : AbstractParser<PurchaseFromCatalogMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new PurchaseFromCatalogMessage
    {
        PageId = packet.PopInt(),
        OfferId = packet.PopInt(),
        ExtraParam = packet.PopString(),
        Quantity = packet.PopInt()
    };
}
