using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Handshake;

public class UserObjectMessageSerializer() : AbstractSerializer<UserObjectMessage>(MessageComposer.UserObjectComposer)
{
    protected override void Serialize(IServerPacket packet, UserObjectMessage message)
    {
        packet.WriteInteger(message.Player.Id);
        packet.WriteString(message.Player.Name);
        packet.WriteString(message.Player.Figure);
        packet.WriteString(message.Player.Gender.ToString());
        packet.WriteString(message.Player.Motto);
        packet.WriteString(message.Player.Name); // real name
        packet.WriteBoolean(false); // direct mail
        packet.WriteInteger(0); // respect total
        packet.WriteInteger(0); // respect left
        packet.WriteInteger(0); // pet respect left
        packet.WriteBoolean(false); // stream publishing enabled
        packet.WriteString(message.Player.PlayerDetails.DateCreated.ToString()); // last online
        packet.WriteBoolean(false); // can name change
        packet.WriteBoolean(false); // account safety locked
    }
}