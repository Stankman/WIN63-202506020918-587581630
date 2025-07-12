using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Pets;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Inventory.Pets;
public class GetPetInventoryParser : AbstractParser<GetPetInventoryMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetPetInventoryMessage();
}
