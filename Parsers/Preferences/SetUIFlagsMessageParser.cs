using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Preferences;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202407091256704579380.Parsers.Preferences;

public class SetUIFlagsMessageParser : AbstractParser<SetUIFlagsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new SetUIFlagsMessage
    {

    };
}
