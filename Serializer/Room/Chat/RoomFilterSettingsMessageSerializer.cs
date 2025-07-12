using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Room.Chat;

public class RoomFilterSettingsMessageSerializer() : AbstractSerializer<RoomFilterSettingsMessage>(MessageComposer.RoomFilterSettingsMessageComposer)
{
    protected override void Serialize(IServerPacket packet, RoomFilterSettingsMessage message)
    {
        packet.WriteInteger(message.BadWords.Count);

        foreach (var badWord in message.BadWords) packet.WriteString(badWord);
    }
}