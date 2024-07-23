using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Purse;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Inventory.Purse;

public class GetCreditsInfoParser : AbstractParser<GetCreditsInfoMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetCreditsInfoMessage();
}