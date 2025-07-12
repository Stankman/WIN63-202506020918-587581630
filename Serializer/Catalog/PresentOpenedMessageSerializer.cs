using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Furniture;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Catalog;

public class PresentOpenedMessageSerializer() : AbstractSerializer<PresentOpenedMessage>(MessageComposer.PresentOpenedMessageComposer)
{
    protected override void Serialize(IServerPacket packet, PresentOpenedMessage message)
    {
    }
}
