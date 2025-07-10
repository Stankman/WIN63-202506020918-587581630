using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Users;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.User;

public class UserBadgesMessageSerializer() : AbstractSerializer<UserBadgesMessage>(MessageComposer.HabboUserBadgesMessageComposer)
{
    protected override void Serialize(IServerPacket packet, UserBadgesMessage message)
    {
        packet.WriteInteger(message.PlayerId);
        packet.WriteInteger(message.ActiveBadges.Count);

        foreach (var badge in message.ActiveBadges)
        {
            packet.WriteInteger(badge.SlotId ?? 0);
            packet.WriteString(badge.BadgeCode);
        }
    }
}
