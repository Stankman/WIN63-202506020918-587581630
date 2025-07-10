using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Room.Avatar;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Room.Avatar;

public class ChangePostureMessageParser : AbstractParser<ChangePostureMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new ChangePostureMessage
    {
        Posture = packet.PopInt()
    };
}
