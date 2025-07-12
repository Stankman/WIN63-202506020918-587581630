﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Layout;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Room.Layout;

public class RoomEntryTileMessageSerializer() : AbstractSerializer<RoomEntryTileMessage>(MessageComposer.RoomEntryTileMessageComposer)
{
    protected override void Serialize(IServerPacket packet, RoomEntryTileMessage message)
    {
        packet.WriteInteger(message.X)
            .WriteInteger(message.Y)
            .WriteInteger((int)message.Direction);
    }
}