﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.MysteryBox;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.MysteryBox;
public class MysteryBoxKeysSerializer() : AbstractSerializer<MysteryBoxKeysMessage>(MessageComposer.MysteryBoxKeysMessageComposer)
{
    protected override void Serialize(IServerPacket packet, MysteryBoxKeysMessage message)
    {
        packet.WriteInteger(0);
    }
}
