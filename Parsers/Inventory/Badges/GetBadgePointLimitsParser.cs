using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Badges;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Inventory.Badges;

public class GetBadgePointLimitsParser : AbstractParser<GetBadgePointLimitsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetBadgePointLimitsMessage();
}