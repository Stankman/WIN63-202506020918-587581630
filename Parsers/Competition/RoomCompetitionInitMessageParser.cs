using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Competition;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Competition;

public class RoomCompetitionInitMessageParser : AbstractParser<RoomCompetitionInitMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new RoomCompetitionInitMessage();
}
