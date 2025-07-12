﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Session;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.room;

public class OpenFlatConnectionMessageParser : AbstractParser<OpenFlatConnectionMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new OpenFlatConnectionMessage
    {
        RoomId = packet.PopInt(),
        Password = packet.PopString(),
        Unused = packet.PopInt()
    };
}