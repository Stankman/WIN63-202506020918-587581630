﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Catalog;
public class GetCatalogPageParser : AbstractParser<GetCatalogPageMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetCatalogPageMessage
    {
        PageId = packet.PopInt(),
        OfferId = packet.PopInt(),
        Type = packet.PopString()
    };
}
