using Turbo.Core.Game.Navigator.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Navigator;

public class CreateFlatMessageParser : AbstractParser<CreateFlatMessage>
{
    public override IMessageEvent Parse(IClientPacket packet)
    {
        var flatName = packet.PopString();
        var flatDescription = packet.PopString();
        var flatModelName = packet.PopString();
        var categoryID = packet.PopInt();
        var maxPlayers = packet.PopInt();
        var tradeType = packet.PopInt();

        RoomTradeSetting tradeSetting = tradeType switch
        {
            1 => RoomTradeSetting.TradingRoomOwnerAndRights,
            2 => RoomTradeSetting.TradingAllowed,
            _ => RoomTradeSetting.TradingNotAllowed
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