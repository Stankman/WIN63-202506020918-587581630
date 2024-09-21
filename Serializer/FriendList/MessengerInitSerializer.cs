using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.FriendList;

public class MessengerInitSerializer() : AbstractSerializer<MessengerInitMessage>(MessageComposer.MessengerInitComposer)
{
    protected override void Serialize(IServerPacket packet, MessengerInitMessage message)
    {
    }
}
