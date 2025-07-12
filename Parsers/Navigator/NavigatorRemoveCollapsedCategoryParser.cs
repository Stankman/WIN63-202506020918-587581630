using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Navigator;

public class NavigatorRemoveCollapsedCategoryParser : AbstractParser<NavigatorRemoveCollapsedCategoryMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new NavigatorRemoveCollapsedCategoryMessage
    {
        CategoryName = packet.PopString()
    };
}