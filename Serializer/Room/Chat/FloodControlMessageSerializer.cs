using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Room.Chat;

public class FloodControlMessageSerializer() : AbstractSerializer<FloodControlMessage>(MessageComposer.FloodControlMessageComposer)
{
    protected override void Serialize(IServerPacket packet, FloodControlMessage message)
    {
        packet.WriteInteger(message.Seconds);
    }
}