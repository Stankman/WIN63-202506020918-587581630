using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class NewNavigatorPreferencesSerializer() : AbstractSerializer<NewNavigatorPreferencesMessage>(MessageComposer.NewNavigatorPreferencesComposer)
{
    protected override void Serialize(IServerPacket packet, NewNavigatorPreferencesMessage message)
    {
        packet.WriteInteger(message.WindowX)
            .WriteInteger(message.WindowY)
            .WriteInteger(message.WindowWidth)
            .WriteInteger(message.WindowHeight)
            .WriteBoolean(message.LeftPaneHidden)
            .WriteInteger(message.ResultMode);
    }
}