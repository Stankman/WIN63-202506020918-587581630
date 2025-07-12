﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Parsers;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Parsers.room;

public class GamePlayerValueMessageSerializer() : AbstractSerializer<GamePlayerValueMessage>(MessageComposer.GamePlayerValueMessageComposer)
{
    protected override void Serialize(IServerPacket packet, GamePlayerValueMessage message)
    {
        packet.WriteInteger(message.UserId)
            .WriteInteger(message.Value);
    }
}