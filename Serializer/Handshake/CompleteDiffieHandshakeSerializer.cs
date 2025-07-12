using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Handshake;

public class CompleteDiffieHandshakeSerializer()
    : AbstractSerializer<CompleteDiffieHandshakeComposer>(MessageComposer.CompleteDiffieHandshakeComposer)
{
    protected override void Serialize(IServerPacket packet, CompleteDiffieHandshakeComposer message)
    {
        packet.WriteString(message.PublicKey);
    }
}