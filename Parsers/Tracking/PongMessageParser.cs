﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Tracking;

public class PongMessageParser : AbstractParser<PongMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        return new PongMessage();
    }
}