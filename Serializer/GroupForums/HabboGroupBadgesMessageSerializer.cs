using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.GroupForums;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.GroupForums;
public class HabboGroupBadgesMessageSerializer() : AbstractSerializer<HabboGroupBadgesMessage>(MessageComposer.HabboGroupBadgesMessageComposer)
{
    protected override void Serialize(IServerPacket packet, HabboGroupBadgesMessage message)
    {
        packet.WriteInteger(0);
    }
}
