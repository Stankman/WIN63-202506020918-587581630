using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Navigator;

public class GetGuestRoomParser : AbstractParser<GetGuestRoomMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetGuestRoomMessage
    {
        RoomId = packet.PopInt(),
        EnterRoom = packet.PopInt() == 1,
        RoomForward = packet.PopInt() == 1
    };
}