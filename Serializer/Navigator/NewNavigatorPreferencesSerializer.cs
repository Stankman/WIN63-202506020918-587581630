using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Navigator;

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