using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Serializer.Handshake;

public class SSOTicketMessageParser : AbstractParser<SSOTicketMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new SSOTicketMessage
    {
        SSO = packet.PopString(),
        ElapsedMilliseconds = packet.PopInt()
    };
}