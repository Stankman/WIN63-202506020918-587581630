using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Tracking;

public class PerformanceLogMessageParser : AbstractParser<PerformanceLogMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new PerformanceLogMessage
    {
        ElapsedTime = packet.PopInt(),
        UserAgent = packet.PopString(),
        FlashVersion = packet.PopString(),
        OS = packet.PopString(),
        Browser = packet.PopString(),
        IsDebugger = packet.PopBoolean(),
        MemoryUsage = packet.PopInt(),
        unknownField = packet.PopInt(),
        GarbageCollections = packet.PopInt(),
        AverageFrameRate = packet.PopInt(),
        SlowUpdates = packet.PopInt()
    };
}