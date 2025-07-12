using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Handshake;

public class InitDiffieHandshakeSerializer()
    : AbstractSerializer<InitDiffieHandshakeComposer>(MessageComposer.InitDiffieHandshakeComposer)
{
    protected override void Serialize(IServerPacket packet, InitDiffieHandshakeComposer composer) =>
        packet
            .WriteString(composer.Prime)
            .WriteString(composer.Generator);
}