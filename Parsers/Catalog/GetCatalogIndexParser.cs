using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Catalog;

public class GetCatalogIndexParser : AbstractParser<GetCatalogIndexMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetCatalogIndexMessage
    {
        Type = packet.PopString()
    };
}
