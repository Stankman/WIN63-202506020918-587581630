﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Room.Action;
public class DanceMessageSerializer() : AbstractSerializer<DanceMessage>(MessageComposer.DanceMessageComposer)
{
    protected override void Serialize(IServerPacket packet, DanceMessage message)
    {
        packet.WriteInteger(message.ObjectId);
        packet.WriteInteger(message.DanceStyle);
    }
}