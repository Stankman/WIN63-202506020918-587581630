using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Camera;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Camera;

public class RequestCameraConfigurationMessageParser : AbstractParser<RequestCameraConfigurationMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new RequestCameraConfigurationMessage();
}
