using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Chat;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Room.Chat;

public class StartTypingMessageParser : AbstractParser<StartTypingMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        return new StartTypingMessage();
    }
}