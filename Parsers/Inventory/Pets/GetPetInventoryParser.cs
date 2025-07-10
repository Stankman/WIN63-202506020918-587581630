using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Pets;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Inventory.Pets;
public class GetPetInventoryParser : AbstractParser<GetPetInventoryMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetPetInventoryMessage();
}
