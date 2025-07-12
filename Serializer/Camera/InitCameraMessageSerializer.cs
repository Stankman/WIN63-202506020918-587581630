using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Camera;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Camera;

public class InitCameraMessageSerializer() : AbstractSerializer<InitCameraMessage>(MessageComposer.InitCameraMessageComposer)
{
    protected override void Serialize(IServerPacket packet, InitCameraMessage message)
    {
        packet.WriteInteger(2); //Credits
        packet.WriteInteger(0); //Points Amount
        packet.WriteInteger(10); //Points Type
    }
}
