using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Room.Chat;

public class ShoutMessageSerializer() : AbstractSerializer<ShoutMessage>(MessageComposer.ShoutMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ShoutMessage message)
    {
        packet.WriteInteger(message.ObjectId);
        packet.WriteString(message.Text);
        packet.WriteInteger(message.Gesture);
        packet.WriteInteger(message.StyleId);
        packet.WriteInteger(message.Links.Count);

        foreach (var link in message.Links)
        {
            packet.WriteString(link);
            packet.WriteString(""); // something
            packet.WriteBoolean(false); // something
        }

        packet.WriteInteger(message.AnimationLength);
    }
}