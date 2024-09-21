using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Handshake;
public class IsFirstLoginOfDaySerializer() : AbstractSerializer<IsFirstLoginOfDayMessage>(MessageComposer.IsFirstLoginOfDayMessageComposer)
{
    protected override void Serialize(IServerPacket packet, IsFirstLoginOfDayMessage message)
    {
        packet.WriteBoolean(false);
    }
}
