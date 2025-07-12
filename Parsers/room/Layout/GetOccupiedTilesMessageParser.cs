using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Layout;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Room.Layout;

public class GetOccupiedTilesMessageParser : AbstractParser<GetOccupiedTilesMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetOccupiedTilesMessage();
}