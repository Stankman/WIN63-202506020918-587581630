using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Tracking;

public class LatencyPingReportMessageParser : AbstractParser<LatencyPingReportMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new LatencyPingReportMessage
    {
        AverageLatency = packet.PopInt(),
        ValidPingAverage = packet.PopInt(),
        NumPings = packet.PopInt()
    };
}