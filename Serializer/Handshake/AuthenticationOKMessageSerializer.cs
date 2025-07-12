using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Handshake;

public class AuthenticationOKMessageSerializer()
    : AbstractSerializer<AuthenticationOKMessage>(MessageComposer.AuthenticationOKMessageComposer)
{
    protected override void Serialize(IServerPacket packet, AuthenticationOKMessage message)
    {
        packet.WriteInteger(message.AccountId ?? 0);
        packet.WriteInteger(message.SuggestedLoginActions?.Length ?? 0);
        if (message.SuggestedLoginActions != null)
        {
            foreach (var action in message.SuggestedLoginActions)
            {
                packet.WriteShort(action);
            }
        }

        packet.WriteInteger(message.IdentityId ?? 0);
    }
}