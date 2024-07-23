using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Tracking;

public class EventLogMessageParser : AbstractParser<EventLogMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new EventLogMessage
    {
        Event = packet.PopString(),
        Data = packet.PopString(),
        Action = packet.PopString(),
        ExtraString = packet.PopString(),
        ExtraInt = packet.PopInt()
    };
}