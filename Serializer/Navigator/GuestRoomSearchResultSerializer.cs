using Turbo.Core.Game.Navigator;
using Turbo.Core.Game.Rooms;
using Turbo.Core.Game.Rooms.Constants;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class GuestRoomSearchResultSerializer() : AbstractSerializer<GuestRoomSearchResultMessage>(MessageComposer.GuestRoomSearchResultComposer)
{
    protected override void Serialize(IServerPacket packet, GuestRoomSearchResultMessage message)
    {
        packet.WriteInteger(message.SearchType);
        packet.WriteString(message.SearchParam);
        
        packet.WriteInteger(message.Rooms.Count);
        foreach (var room in message.Rooms)
        {
            SerializeRoomData(packet, room);
        }
        
        var hasAd = message.Ad != null;
        packet.WriteBoolean(hasAd);
        if (hasAd)
        {
            SerializeAdData(packet, message.Ad);
        }
    }
    
    private void SerializeRoomData(IServerPacket packet, IRoomDetails roomDetails)
    {
        packet.WriteInteger(roomDetails.Id); // Room ID
        packet.WriteString(roomDetails.Name); // Room Name
        packet.WriteString(roomDetails.PlayerName); // Owner Name
        packet.WriteInteger(roomDetails.UsersNow); // Current User Count
        packet.WriteInteger(roomDetails.UsersMax); // Max User Count
        packet.WriteString(roomDetails.Description); // Room Description
        packet.WriteInteger((int)roomDetails.State); // Room State (Open, Locked, etc.)
        packet.WriteInteger((int)roomDetails.TradeType); // Trade settings
        packet.WriteInteger(0); // Room Score
        packet.WriteInteger(0); // Room Ranking
        packet.WriteInteger(1); // Category ID
        packet.WriteInteger(0); // Number of tags

        // Serialize the bitmask for the room.
        SerializeBitmask(packet, roomDetails);
    }

    private void SerializeBitmask(IServerPacket packet, IRoomDetails roomDetails)
    {
        int bitmask = 0;

        // Check and add settings to the bitmask.
        if (roomDetails.AllowPets) bitmask |= (int)RoomBitmaskType.AllowPets;
        bitmask += (int)RoomBitmaskType.ShowOwner;

        packet.WriteInteger(bitmask);

        // If specific bits are set, serialize those fields.
        if ((bitmask & (int)RoomBitmaskType.GroupData) > 0)
        {
            packet.WriteInteger(0);
            packet.WriteString("");
            packet.WriteString("");
        }

        if ((bitmask & (int)RoomBitmaskType.RoomAd) > 0)
        {
            packet.WriteString("");
            packet.WriteString("");
            packet.WriteString("");
        }
    }

    private void SerializeAdData(IServerPacket packet, IAdData ad)
    {
        packet.WriteString(ad.Name); // Ad Name
        packet.WriteString(ad.Description); // Ad Description
        packet.WriteString(ad.Expiry); // Ad Expiry
    }
}