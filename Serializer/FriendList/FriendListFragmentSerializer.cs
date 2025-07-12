using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.FriendList;
public class FriendListFragmentSerializer() : AbstractSerializer<FriendListFragmentMessage>(MessageComposer.FriendListFragmentMessageComposer)
{
    protected override void Serialize(IServerPacket packet, FriendListFragmentMessage message)
    {
    }
}