﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Guilds;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.GroupForums;

public class GetUnreadForumsCountMessageParser : AbstractParser<GetUnreadForumsCountMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetUnreadForumsCountMessage();
}