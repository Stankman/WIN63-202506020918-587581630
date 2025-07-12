using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.room;

public class MoveAvatarMessageParser : AbstractParser<MoveAvatarMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        return new MoveAvatarMessage
        {
            X = packet.PopInt(),
            Y = packet.PopInt()
        };
    }
}