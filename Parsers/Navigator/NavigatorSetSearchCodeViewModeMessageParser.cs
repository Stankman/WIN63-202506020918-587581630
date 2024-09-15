using Turbo.Core.Game.Navigator.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Navigator;

public class NavigatorSetSearchCodeViewModeMessageParser : AbstractParser<NavigatorSetSearchCodeViewModeMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        var categoryName = packet.PopString();
        var viewModeInt = packet.PopInt();

        NavigatorResultsMode viewMode = viewModeInt switch
        {
            1 => NavigatorResultsMode.Tiles,
            _ => NavigatorResultsMode.Rows
        };

        return new NavigatorSetSearchCodeViewModeMessage
        {
            CategoryName = categoryName,
            ViewMode = viewMode
        };
    }
}