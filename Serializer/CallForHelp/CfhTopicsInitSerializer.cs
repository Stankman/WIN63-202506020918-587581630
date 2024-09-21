using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.CallForHelp;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.CallForHelp;
public class CfhTopicsInitSerializer() : AbstractSerializer<CfhTopicsInitMessage>(MessageComposer.CfhTopicsInitMessageComposer)
{
    protected override void Serialize(IServerPacket packet, CfhTopicsInitMessage message)
    {
        packet.WriteInteger(0);
    }
}