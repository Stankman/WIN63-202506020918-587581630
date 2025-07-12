using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.NewNavigator;

public class NewNavigatorInitParser : AbstractParser<NewNavigatorInitMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new NewNavigatorInitMessage();
}