using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Tracking;

public class LagWarningReportMessageParser : AbstractParser<LagWarningReportMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new LagWarningReportMessage()
    {
        WarningCount = packet.PopInt()
    };
}