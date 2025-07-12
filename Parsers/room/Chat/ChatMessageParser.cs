using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Chat;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Room.Chat;

public class ChatMessageParser : AbstractParser<ChatMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        var text = packet.PopString();
        var styleId = packet.PopInt();
        var chatTrackingId = 0;

        if (packet.RemainingLength() >= sizeof(int))
            chatTrackingId = packet.PopInt();

        return new ChatMessage
        {
            Text = text,
            StyleId = styleId,
            ChatTrackingId = chatTrackingId
        };
    }
}