using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Tracking;

public class LagWarningReportMessageParser : AbstractParser<LagWarningReportMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new LagWarningReportMessage()
    {
        WarningCount = packet.PopInt()
    };
}