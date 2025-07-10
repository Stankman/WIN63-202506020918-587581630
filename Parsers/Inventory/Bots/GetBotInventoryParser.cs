using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Bots;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Inventory.Bots;
public class GetBotInventoryParser : AbstractParser<GetBotInventoryMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetBotInventoryMessage();
}
