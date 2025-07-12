using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Parsers.room;

public class FlatAccessibleMessageSerializer() : AbstractSerializer<FlatAccessibleMessage>(MessageComposer.FlatAccessibleMessageComposer)
{
    protected override void Serialize(IServerPacket packet, FlatAccessibleMessage message)
    {
        packet.WriteInteger(message.RoomId);
        packet.WriteString(message.Username);
    }
}