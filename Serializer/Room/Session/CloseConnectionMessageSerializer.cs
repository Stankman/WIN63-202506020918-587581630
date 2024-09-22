using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Parsers.room;

public class CloseConnectionMessageSerializer() : AbstractSerializer<CloseConnectionMessage>(MessageComposer.CloseConnectionMessageComposer)
{
    protected override void Serialize(IServerPacket packet, CloseConnectionMessage message)
    {
        // not used
    }
}