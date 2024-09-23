using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Room.Chat;

public class RoomChatSettingsMessageSerializer() : AbstractSerializer<RoomChatSettingsMessage>(MessageComposer.RoomChatSettingsMessageComposer)
{
    protected override void Serialize(IServerPacket packet, RoomChatSettingsMessage message)
    {
        packet.WriteInteger((int)message.ChatMode);
        packet.WriteInteger((int)message.ChatWeight);
        packet.WriteInteger((int)message.ChatSpeed);
        packet.WriteInteger(message.ChatDistance);
        packet.WriteInteger((int)message.ChatProtection);
    }
}