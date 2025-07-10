using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Users;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Users;
public class GetHabboGroupBadgesMessageParser : AbstractParser<GetHabboGroupBadgesMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetHabboGroupBadgesMessage();
}