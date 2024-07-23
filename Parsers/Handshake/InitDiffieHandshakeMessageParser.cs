using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Handshake;

public class InitDiffieHandshakeMessageParser : AbstractParser<InitDiffieHandshakeMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new InitDiffieHandshakeMessage();
}