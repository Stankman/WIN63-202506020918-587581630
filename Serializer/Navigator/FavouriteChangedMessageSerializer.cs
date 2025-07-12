using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Navigator;

public class FavouriteChangedMessageSerializer()
    : AbstractSerializer<FavouriteChangedMessage>(MessageComposer.FavouriteChangedComposer)
{
    protected override void Serialize(IServerPacket packet, FavouriteChangedMessage message)
    {
        packet.WriteInteger(message.RoomId);
        packet.WriteBoolean(message.Added);
    }
}