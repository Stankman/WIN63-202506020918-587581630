using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class SlideObjectBundleMessageSerializer() : AbstractSerializer<SlideObjectBundleMessage>(MessageComposer.SlideObjectBundleMessageComposer)
{
    protected override void Serialize(IServerPacket packet, SlideObjectBundleMessage message)
    {
        packet.WriteInteger(message.OldPos.X);
        packet.WriteInteger(message.OldPos.Y);
        packet.WriteInteger(message.NewPos.X);
        packet.WriteInteger(message.NewPos.Y);

        packet.WriteInteger(message.Furniture.Count);

        foreach (var obj in message.Furniture)
        {
            packet.WriteInteger(obj.RoomObject.Id);
            packet.WriteString(string.Format("{0:N3}", obj.Height));
            packet.WriteString(string.Format("{0:N3}", obj.HeightNext));
        }

        packet.WriteInteger(message.RollerItemId);

        if (message.Avatar != null)
        {
            packet.WriteInteger((int)message.MoveType);
            packet.WriteInteger(message.Avatar.RoomObject.Id);
            packet.WriteString(string.Format("{0:N3}", message.Avatar.Height));
            packet.WriteString(string.Format("{0:N3}", message.Avatar.HeightNext));
        }
    }
}