using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Room.Chat;

public class UserTypingMessageSerializer() : AbstractSerializer<UserTypingMessage>(MessageComposer.UserTypingMessageComposer)
{
    protected override void Serialize(IServerPacket packet, UserTypingMessage message)
    {
        packet.WriteInteger(message.ObjectId);
        packet.WriteInteger(message.IsTyping ? 1 : 0);
    }
}