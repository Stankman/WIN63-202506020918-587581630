﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.room;

public class OpenConnectionMessageSerializer() : AbstractSerializer<OpenConnectionMessage>(MessageComposer.OpenConnectionMessageComposer)
{
    protected override void Serialize(IServerPacket packet, OpenConnectionMessage message)
    {
        packet.WriteInteger(message.RoomId);
    }
}