using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Users;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Users;

public class GetUserNftChatStylesMessageParser : AbstractParser<GetUserNftChatStylesMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetUserNftChatStylesMessage();
}