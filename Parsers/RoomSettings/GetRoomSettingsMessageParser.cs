using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.RoomSettings;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.RoomSettings;

public class GetRoomSettingsMessageParser : AbstractParser<GetRoomSettingsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetRoomSettingsMessage
    {
        RoomId = packet.PopInt()
    };
}
