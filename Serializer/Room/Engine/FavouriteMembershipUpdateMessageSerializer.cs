using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class FavouriteMembershipUpdateMessageSerializer() : AbstractSerializer<FavouriteMembershipUpdateMessage>(MessageComposer.FavoriteMembershipUpdateMessageComposer)
{
    protected override void Serialize(IServerPacket packet, FavouriteMembershipUpdateMessage message)
    {
        packet.WriteInteger(message.RoomIndex);
        packet.WriteInteger(message.GroupId);
        packet.WriteInteger((int)message.Status);
        packet.WriteString(message.GroupName);
    }
}