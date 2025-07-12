using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Navigator;

public class UpdateHomeRoomParser : AbstractParser<UpdateHomeRoomMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new UpdateHomeRoomMessage
    {
        RoomId = packet.PopInt()
    };
}