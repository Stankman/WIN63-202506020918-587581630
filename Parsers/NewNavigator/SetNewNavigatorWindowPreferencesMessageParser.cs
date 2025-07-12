using Turbo.Core.Game.Navigator.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.NewNavigator;

public class SetNewNavigatorWindowPreferencesMessageParser : AbstractParser<SetNewNavigatorWindowPreferencesMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new SetNewNavigatorWindowPreferencesMessage
    {
        X = packet.PopInt(),
        Y = packet.PopInt(),
        Width = packet.PopInt(),
        Height = packet.PopInt(),
        OpenSavedSearches = packet.PopBoolean(),
        ResultsMode = (NavigatorResultsMode)packet.PopInt()
    };
}