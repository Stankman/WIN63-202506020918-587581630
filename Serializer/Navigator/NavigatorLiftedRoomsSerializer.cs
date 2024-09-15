using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class NavigatorLiftedRoomsSerializer() : AbstractSerializer<NavigatorLiftedRoomsMessage>(MessageComposer.NavigatorLiftedRoomsComposer)
{
    protected override void Serialize(IServerPacket packet, NavigatorLiftedRoomsMessage message)
    {
        // Ensure LiftedRooms is not null
        if (message.LiftedRooms == null)
        {
            packet.WriteInteger(0); // Write 0 if there are no rooms
            return;
        }

        packet.WriteInteger(message.LiftedRooms.Count); // Write the count of lifted rooms

        foreach (var room in message.LiftedRooms)
        {
            packet.WriteInteger(room.FlatId);
            packet.WriteInteger(room.Unused);
            packet.WriteString(room.Image);
            packet.WriteString(room.Caption);
        }
    }
}