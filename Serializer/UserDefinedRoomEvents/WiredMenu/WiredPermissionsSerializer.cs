using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.UserDefinedRoomEvents.WiredMenu;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.UserDefinedRoomEvents.WiredMenu;
public class WiredPermissionsSerializer() : AbstractSerializer<WiredPermissionsMessage>(MessageComposer.WiredPermissionsComposer)
{
    protected override void Serialize(IServerPacket packet, WiredPermissionsMessage message)
    {
        packet.WriteBoolean(message.CanModify);
        packet.WriteBoolean(message.CanRead);
    }
}
