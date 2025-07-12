﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Room.Action;
public class SleepMessageSerializer() : AbstractSerializer<SleepMessage>(MessageComposer.SleepMessageComposer)
{
    protected override void Serialize(IServerPacket packet, SleepMessage message)
    {
        packet.WriteInteger(message.ObjectId);
        packet.WriteBoolean(message.Sleeping);
    }
}
