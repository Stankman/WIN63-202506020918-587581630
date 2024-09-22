using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Parsers.room;

public class YouArePlayingGameMessageSerializer() : AbstractSerializer<YouArePlayingGameMessage>(MessageComposer.YouArePlayingGameMessageComposer)
{
    protected override void Serialize(IServerPacket packet, YouArePlayingGameMessage message)
    {
        packet.WriteBoolean(message.IsPlaying);
    }
}