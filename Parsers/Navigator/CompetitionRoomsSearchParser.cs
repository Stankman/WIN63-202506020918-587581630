using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Navigator;

public class CompetitionRoomsSearchParser : AbstractParser<CompetitionRoomsSearchMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new CompetitionRoomsSearchMessage
    {
        Unknown1 = packet.PopInt(),
        Unknown2 = packet.PopInt()
    };
}