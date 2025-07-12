using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Achievements;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Inventory.Achievements;

public class AchievementsSerializer() : AbstractSerializer<AchievementsMessage>(MessageComposer.AchievementsComposer)
{
    protected override void Serialize(IServerPacket packet, AchievementsMessage message)
    {
        packet.WriteInteger(0); //Achievements Count

        //Serialize each achievement
        //packet.WriteInteger(achievement.Id);
        //packet.WriteInteger(achievement.NextLevel);
        //packet.WriteString(achievement.NextLevelBadgeCode);
        //packet.WriteInteger(achievement.PreviousProgressRequirement);
        //packet.WriteInteger(achievement.CurrentProgressRequirement);
        //packet.WriteInteger(achievement.NextLevelRewardPoints);
        //packet.WriteInteger(achievement.NextLevelRewardPointsType);
        //packet.WriteInteger(achievement.CurrentProgress);
        //packet.WriteBool(achievement.Completed);
        //packet.WriteString(achievement.Category);
        //packet.WriteString("");
        //packet.WriteInteger(achievement.MaximumLevel);
        //packet.WriteInteger(achievement.DisplayMode);
        //packet.WriteInteger((short)achievement.State);

        packet.WriteString(""); //DefaultCategory
    }
}
