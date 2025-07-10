using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Furni;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Inventory.Furni;

public class RequestFurniInventoryWhenNotInRoomParser : AbstractParser<RequestFurniInventoryWhenNotInRoomMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new RequestFurniInventoryWhenNotInRoomMessage();
}