using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Notifications;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Notifications;

public class ResetUnseenItemsParser : AbstractParser<ResetUnseenItemsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new ResetUnseenItemsMessage();
}
