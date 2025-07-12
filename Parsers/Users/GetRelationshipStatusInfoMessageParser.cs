using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Users;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Users;
public class GetRelationshipStatusInfoMessageParser : AbstractParser<GetRelationshipStatusInfoMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetRelationshipStatusInfoMessage
    {
        PlayerId = packet.PopInt(),
    };
}
