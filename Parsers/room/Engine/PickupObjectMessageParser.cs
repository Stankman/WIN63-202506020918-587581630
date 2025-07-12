using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Room.Engine;
public class PickupObjectMessageParser : AbstractParser<PickupObjectMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new PickupObjectMessage
    {
        ObjectCategory = packet.PopInt(),
        ObjectId = packet.PopInt()
    };
}
