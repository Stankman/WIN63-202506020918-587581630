using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog.Clothing;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Catalog.Clothing;
public class FigureSetIdsSerializer() : AbstractSerializer<FigureSetIdsMessage>(MessageComposer.FigureSetIdsMessageComposer)
{
    protected override void Serialize(IServerPacket packet, FigureSetIdsMessage message)
    {
        packet.WriteInteger(0);//length

        packet.WriteInteger(0);//length
    }
}
