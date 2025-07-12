﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class RoomReadyMessageSerializer() : AbstractSerializer<RoomReadyMessage>(MessageComposer.RoomReadyMessageComposer)
{
    protected override void Serialize(IServerPacket packet, RoomReadyMessage message)
    {
        packet.WriteString(message.RoomType)
            .WriteInteger(message.RoomId);
    }
}