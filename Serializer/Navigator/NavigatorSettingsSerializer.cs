using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Navigator;

public class NavigatorSettingsSerializer() : AbstractSerializer<NavigatorSettingsMessage>(MessageComposer.NavigatorSettingsComposer)
{
    protected override void Serialize(IServerPacket packet, NavigatorSettingsMessage message)
    {
        packet.WriteInteger(message.HomeRoomId)
            .WriteInteger(message.RoomIdToEnter);
    }
}