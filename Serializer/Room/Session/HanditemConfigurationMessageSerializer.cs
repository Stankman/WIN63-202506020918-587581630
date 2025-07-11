using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Room.Session;

public class HanditemConfigurationMessageSerializer() : AbstractSerializer<HanditemConfigurationMessage>(MessageComposer.HanditemConfigurationMessageComposer)
{
    protected override void Serialize(IServerPacket packet, HanditemConfigurationMessage message)
    {
        packet.WriteBoolean(false);
    }
}