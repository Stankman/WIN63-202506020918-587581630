using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Handshake;
public class IsFirstLoginOfDaySerializer() : AbstractSerializer<IsFirstLoginOfDayMessage>(MessageComposer.IsFirstLoginOfDayComposer)
{
    protected override void Serialize(IServerPacket packet, IsFirstLoginOfDayMessage message)
    {
        packet.WriteBoolean(false);
    }
}
