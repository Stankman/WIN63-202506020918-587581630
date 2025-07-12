using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Handshake;

public class ClientHelloParser : AbstractParser<ClientHelloMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new ClientHelloMessage
    {
        Production = packet.PopString(),
    };
}