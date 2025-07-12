using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Navigator;

public class SetRoomSessionTagsParser : AbstractParser<SetRoomSessionTagsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new SetRoomSessionTagsMessage
    {
        Tag1 = packet.PopString(),
        Tag2 = packet.PopString()
    };
}