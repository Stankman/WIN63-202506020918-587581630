using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Handshake;

public class UserRightsMessageSerializer()
    : AbstractSerializer<UserRightsMessage>(MessageComposer.UserRightsMessageComposer)
{
    protected override void Serialize(IServerPacket packet, UserRightsMessage message)
    {
        packet.WriteInteger((int)message.ClubLevel);
        packet.WriteInteger((int)message.SecurityLevel);
        packet.WriteBoolean(message.IsAmbassador);
    }
}