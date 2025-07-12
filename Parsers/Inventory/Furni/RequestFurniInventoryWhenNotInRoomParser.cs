using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Furni;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Inventory.Furni;

public class RequestFurniInventoryWhenNotInRoomParser : AbstractParser<RequestFurniInventoryWhenNotInRoomMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new RequestFurniInventoryWhenNotInRoomMessage();
}