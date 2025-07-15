using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.FriendList;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.FriendList;

public class MessengerInitMessageParser : AbstractParser<MessengerInitMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new MessengerInitMessage();
}