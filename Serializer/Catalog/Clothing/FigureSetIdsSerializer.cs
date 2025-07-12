using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog.Clothing;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Catalog.Clothing;
public class FigureSetIdsSerializer() : AbstractSerializer<FigureSetIdsMessage>(MessageComposer.FigureSetIdsComposer)
{
    protected override void Serialize(IServerPacket packet, FigureSetIdsMessage message)
    {
        packet.WriteInteger(0);//length

        packet.WriteInteger(0);//length
    }
}
