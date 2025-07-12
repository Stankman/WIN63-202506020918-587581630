using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming.Inventory.Achievements;
using Turbo.Packets.Parsers;

namespace Turbo.WIN63202506020918587581630.Parsers.Inventory.Achievements;
public class GetAchievementsParser : AbstractParser<GetAchievementsMessage>
{
    public override IMessageEvent Parse(IClientPacket packet) => new GetAchievementsMessage();
}
