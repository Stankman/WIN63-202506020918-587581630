using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Tracking;

public class LatencyPingRequestMessageParser : AbstractParser<LatencyPingRequestMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new LatencyPingRequestMessage()
    {
        ID = packet.PopInt()
    };
}