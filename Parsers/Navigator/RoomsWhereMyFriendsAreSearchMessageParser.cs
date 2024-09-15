using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Navigator;

public class RoomsWhereMyFriendsAreSearchMessageParser : AbstractParser<RoomsWhereMyFriendsAreSearchMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new RoomsWhereMyFriendsAreSearchMessage();
}