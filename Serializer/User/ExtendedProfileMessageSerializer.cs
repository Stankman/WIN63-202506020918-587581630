using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Users;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.User;
internal class ExtendedProfileMessageSerializer() : AbstractSerializer<ExtendedProfileMessage>(MessageComposer.ExtendedProfileMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ExtendedProfileMessage message)
    {
        packet.WriteInteger(message.Player.Id);
        packet.WriteString(message.Player.Name);
        packet.WriteString(message.Player.PlayerDetails.Figure);
        packet.WriteString(message.Player.Motto);
        packet.WriteString("12-12-2000");
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteBoolean(false);
        packet.WriteBoolean(false);
        packet.WriteBoolean(true);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteBoolean(true);
    }
}
