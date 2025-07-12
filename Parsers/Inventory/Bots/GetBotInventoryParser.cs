using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Bots;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Inventory.Bots;
public class GetBotInventoryParser : AbstractParser<GetBotInventoryMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetBotInventoryMessage();
}
