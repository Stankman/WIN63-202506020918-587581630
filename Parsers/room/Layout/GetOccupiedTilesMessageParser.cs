using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Layout;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Room.Layout;

public class GetOccupiedTilesMessageParser : AbstractParser<GetOccupiedTilesMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetOccupiedTilesMessage();
}