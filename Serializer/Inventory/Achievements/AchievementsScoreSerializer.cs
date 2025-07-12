﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Achievements;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Inventory.Achievements;
public class AchievementsScoreSerializer() : AbstractSerializer<AchievementsScoreMessage>(MessageComposer.AchievementsScoreComposer)
{
    protected override void Serialize(IServerPacket packet, AchievementsScoreMessage message)
    {
        packet.WriteInteger(0);
    }
}
