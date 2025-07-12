using Turbo.Core.Game.Rooms;
using Turbo.Core.Packets.Messages;

namespace Turbo.WIN63202506020918587581630.Serializer.RoomSettings.Types;
public static class RoomModerationSettingsSerializer
{
    public static void Serialize(IServerPacket packet, IRoomDetails roomDetails)
    {
        packet.WriteInteger((int)roomDetails.MuteType);
        packet.WriteInteger((int)roomDetails.KickType);
        packet.WriteInteger((int)roomDetails.BanType);
    }
}
