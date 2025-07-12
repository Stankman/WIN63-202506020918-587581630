using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Purse;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Inventory.Purse;

public class GetCreditsInfoParser : AbstractParser<GetCreditsInfoMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetCreditsInfoMessage();
}