using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Nft;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Nft;

public class GetNftCreditsMessageParser : AbstractParser<GetNftCreditsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetNftCreditsMessage();
}