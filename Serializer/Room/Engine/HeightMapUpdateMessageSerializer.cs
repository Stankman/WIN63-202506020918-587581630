using Turbo.Core.Game.Rooms.Mapping;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class HeightMapUpdateMessageSerializer() : AbstractSerializer<HeightMapUpdateMessage>(MessageComposer.HeightMapUpdateMessageComposer)
{
    protected override void Serialize(IServerPacket packet, HeightMapUpdateMessage message)
    {
        packet.WriteByte(message.TilesToUpdate.Count);
        foreach(IRoomTile tile in message.TilesToUpdate) 
        {
            packet.WriteByte(tile.Location.X);
            packet.WriteByte(tile.Location.Y);
            packet.WriteShort(tile.RelativeHeight);
        }
    }
}