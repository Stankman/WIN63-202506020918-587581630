using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Notifications;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Notifications;
public class ActivityPointsSerializer() : AbstractSerializer<ActivityPointsMessage>(MessageComposer.ActivityPointsMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ActivityPointsMessage message)
    {
        packet.WriteInteger(2);
        packet.WriteInteger(0);
        packet.WriteInteger(100);
        packet.WriteInteger(5);
        packet.WriteInteger(5);

        //foreach (var currency in message.playerWallet.Wallet)
        //{
        //    packet.WriteInteger(0); //Currency Type
        //    packet.WriteInteger(0); //Amount
        //}
    }
}
