using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Handshake;

public class PingMessageSerializer() : AbstractSerializer<PingMessage>(MessageComposer.PingMessageComposer)
{
    protected override void Serialize(IServerPacket packet, PingMessage message)
    {
        
    }
}