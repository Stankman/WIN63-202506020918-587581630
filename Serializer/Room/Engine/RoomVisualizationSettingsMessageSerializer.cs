using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class RoomVisualizationSettingsMessageSerializer() : AbstractSerializer<RoomVisualizationSettingsMessage>(MessageComposer.RoomVisualizationSettingsComposer)
{
    protected override void Serialize(IServerPacket packet, RoomVisualizationSettingsMessage message)
    {
        packet.WriteInteger(message.WallThickness);
        packet.WriteInteger(message.FloorThickness);
        packet.WriteBoolean(message.WallsHidden);
    }
}