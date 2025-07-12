using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Navigator;

public class GuildBaseSearchParser : AbstractParser<GuildBaseSearchMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GuildBaseSearchMessage
    {
        Unknown = packet.PopInt()
    };
}