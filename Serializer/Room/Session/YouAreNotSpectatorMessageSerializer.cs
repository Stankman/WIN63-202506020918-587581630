using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Parsers.room;

public class YouAreNotSpectatorMessageSerializer() : AbstractSerializer<YouAreNotSpectatorMessage>(MessageComposer.YouAreNotSpectatorMessageComposer)
{
    protected override void Serialize(IServerPacket packet, YouAreNotSpectatorMessage message)
    {
        packet.WriteInteger(message.flatId);
    }
}