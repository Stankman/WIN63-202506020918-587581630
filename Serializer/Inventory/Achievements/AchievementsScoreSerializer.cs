using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Achievements;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Inventory.Achievements;
public class AchievementsScoreSerializer() : AbstractSerializer<AchievementsScoreMessage>(MessageComposer.AchievementsScoreMessageComposer)
{
    protected override void Serialize(IServerPacket packet, AchievementsScoreMessage message)
    {
        packet.WriteInteger(0);
    }
}
