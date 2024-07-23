using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Nft;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Nft;

public class GetSilverMessageParser : AbstractParser<GetSilverMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetSilverMessage();
}