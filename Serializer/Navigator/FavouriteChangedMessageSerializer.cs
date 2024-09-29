using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class FavouriteChangedMessageSerializer()
    : AbstractSerializer<FavouriteChangedMessage>(MessageComposer.FavouriteChangedComposer)
{
    protected override void Serialize(IServerPacket packet, FavouriteChangedMessage message)
    {
        packet.WriteInteger(message.RoomId);
        packet.WriteBoolean(message.Added);
    }
}