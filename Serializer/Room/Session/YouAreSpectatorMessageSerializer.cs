using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Parsers;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Parsers.room;

public class YouAreSpectatorMessageSerializer() : AbstractSerializer<YouAreSpectatorMessage>(MessageComposer.YouAreSpectatorMessageComposer)
{
    protected override void Serialize(IServerPacket packet, YouAreSpectatorMessage message)
    {
        packet.WriteInteger(message.flatId);
    }
}