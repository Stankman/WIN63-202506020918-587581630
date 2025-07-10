using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Camera;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Camera;

public class RequestCameraConfigurationMessageParser : AbstractParser<RequestCameraConfigurationMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new RequestCameraConfigurationMessage();
}
