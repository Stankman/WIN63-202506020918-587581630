using Turbo.Core.Game.Rooms.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Navigator;

public class CreateFlatParser : AbstractParser<CreateFlatMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        var flatName = packet.PopString();
        var flatDescription = packet.PopString();
        var flatModelName = packet.PopString();
        var categoryID = packet.PopInt();
        var maxPlayers = packet.PopInt();
        var tradeType = packet.PopInt();

        var tradeSetting = tradeType switch
        {
            1 => RoomTradeType.RoomOwnerAndRights,
            2 => RoomTradeType.Everyone,
            _ => RoomTradeType.Disabled
        };

        return new CreateFlatMessage
        {
            FlatName = flatName,
            FlatDescription = flatDescription,
            FlatModelName = flatModelName,
            CategoryID = categoryID,
            MaxPlayers = maxPlayers,
            TradeSetting = tradeSetting
        };
    }
}