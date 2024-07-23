using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Badges;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Inventory.Badges;

public class GetBadgePointLimitsParser : AbstractParser<GetBadgePointLimitsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetBadgePointLimitsMessage();
}