using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Advertising;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Advertising;

public class InterstitialShownMessageParser : AbstractParser<InterstitialShownMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new InterstitialShownMessage();
}