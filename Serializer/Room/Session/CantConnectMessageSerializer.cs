using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Parsers.room;

public class CantConnectMessageSerializer() : AbstractSerializer<CantConnectMessage>(MessageComposer.CantConnectMessageComposer)
{
    protected override void Serialize(IServerPacket packet, CantConnectMessage message)
    {
        packet.WriteInteger((int)message.Reason)
            .WriteString(message.Parameter);
    }
}