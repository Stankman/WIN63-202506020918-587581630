using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Engine;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.room;

public class GetFurnitureAliasesMessageParser : AbstractParser<GetFurnitureAliasesMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetFurnitureAliasesMessage();
}