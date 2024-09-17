using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.NewNavigator;

public class NewNavigatorSearchParser : AbstractParser<NewNavigatorSearchMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new NewNavigatorSearchMessage
    {
        SearchCodeOriginal = packet.PopString(),
        FilteringData = packet.PopString()
    };
}