using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class RoomEntryInfoMessageSerializer() : AbstractSerializer<RoomEntryInfoMessage>(MessageComposer.RoomEntryInfoMessageComposer)
{
    protected override void Serialize(IServerPacket packet, RoomEntryInfoMessage message)
    {
        packet.WriteInteger(message.RoomId);
        packet.WriteBoolean(message.Owner);
    }
}