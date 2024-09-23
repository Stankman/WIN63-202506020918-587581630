using System.Text;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.room;

public class UserUpdateMessageSerializer() : AbstractSerializer<UserUpdateMessage>(MessageComposer.UserUpdateMessageComposer)
{
    protected override void Serialize(IServerPacket packet, UserUpdateMessage message)
    {
        packet.WriteInteger(message.RoomObjects.Count);

        foreach (var avatarObject in message.RoomObjects)
        {
            packet.WriteInteger(avatarObject.Id);
            packet.WriteInteger(avatarObject.Location.X);
            packet.WriteInteger(avatarObject.Location.Y);
            packet.WriteString(avatarObject.Location.Z.ToString());
            packet.WriteInteger((int)avatarObject.Location.HeadRotation);
            packet.WriteInteger((int)avatarObject.Location.Rotation);

            StringBuilder statusString = new StringBuilder("/");

            foreach (var status in avatarObject.Logic.Statuses)
            {
                statusString
                    .Append(status.Key)
                    .Append(' ')
                    .Append(status.Value)
                    .Append('/');
            }

            packet.WriteString(statusString.ToString());
        }
    }
}