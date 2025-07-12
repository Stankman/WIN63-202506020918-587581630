using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Advertising;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Advertising;

public class InterstitialMessageSerializer() : AbstractSerializer<InterstitialMessage>(MessageComposer.InterstitialMessageComposer)
{
    protected override void Serialize(IServerPacket packet, InterstitialMessage message)
    {
        packet.WriteBoolean(false);
        //packet.WriteString(message.imageUrl)
        //    .WriteString(message.clickUrl);
    }
}