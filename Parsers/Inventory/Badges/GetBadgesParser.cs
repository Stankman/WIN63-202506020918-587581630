using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Badges;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Inventory.Badges;
public class GetBadgesParser : AbstractParser<GetBadgesMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetBadgesMessage();
}