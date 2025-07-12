﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.AvatarEffect;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Inventory.AvatarEffect;
public class AvatarEffectsSerializer() : AbstractSerializer<AvatarEffectsMessage>(MessageComposer.AvatarEffectsMessageComposer)
{
    protected override void Serialize(IServerPacket packet, AvatarEffectsMessage message)
    {
        packet.WriteInteger(0);
    }
}
