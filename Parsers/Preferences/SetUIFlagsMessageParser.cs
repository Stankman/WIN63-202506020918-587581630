using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Preferences;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Preferences;

public class SetUIFlagsMessageParser : AbstractParser<SetUIFlagsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new SetUIFlagsMessage
    {

    };
}
