
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Room.Engine;
public class MoveObjectMessageParser : AbstractParser<MoveObjectMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new MoveObjectMessage
    {
        ObjectId = packet.PopInt(),
        X = packet.PopInt(),
        Y = packet.PopInt(),
        Direction = packet.PopInt()
    };
}
