using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Competition;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Competition;

public class GetCurrentTimingCodeMessageParser : AbstractParser<GetCurrentTimingCodeMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetCurrentTimingCodeMessage
    {
        TimingCode = packet.PopString()
    };
}