using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Users;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.User;

public class RelationshipStatusInfoSerializer() : AbstractSerializer<RelationshipStatusInfoMessage>(MessageComposer.RelationshipStatusInfoComposer)
{
    protected override void Serialize(IServerPacket packet, RelationshipStatusInfoMessage message)
    {
        packet.WriteInteger(message.Player.Id);
        packet.WriteInteger(0);

        //packet.WriteInteger(2); //1 = LOVE 2 = FRIENDS 3 = HATERS
        //packet.WriteInteger(0); //Friends Count
        //packet.WriteInteger(1); //Friend Id
        //packet.WriteString(""); //Friend Username
        //packet.WriteString(""); //Friend Look

    }
}
