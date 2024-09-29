using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class FavouritesSerializer() : AbstractSerializer<FavouritesMessage>(MessageComposer.FavouritesComposer)
{
    protected override void Serialize(IServerPacket packet, FavouritesMessage message)
    {
        packet.WriteInteger(message.Limit);
        packet.WriteInteger(message.FavouriteRoomIds.Count);

        foreach (var roomId in message.FavouriteRoomIds) packet.WriteInteger(roomId);
    }
}