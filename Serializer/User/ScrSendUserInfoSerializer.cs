using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Users;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.User;
public class ScrSendUserInfoSerializer() : AbstractSerializer<ScrSendUserInfoMessage>(MessageComposer.ScrSendUserInfoComposer)
{
    protected override void Serialize(IServerPacket packet, ScrSendUserInfoMessage message)
    {
        packet.WriteString("club_habbo");
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(2);
        packet.WriteBoolean(false);
        packet.WriteBoolean(false);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(-1);
    }
}
