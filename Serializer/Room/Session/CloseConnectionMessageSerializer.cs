﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Parsers.room;

public class CloseConnectionMessageSerializer() : AbstractSerializer<CloseConnectionMessage>(MessageComposer.CloseConnectionMessageComposer)
{
    protected override void Serialize(IServerPacket packet, CloseConnectionMessage message)
    {
        // not used
    }
}