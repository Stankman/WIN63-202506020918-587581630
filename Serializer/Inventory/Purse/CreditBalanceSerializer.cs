using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Inventory.Purse;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Inventory.Purse;
public class CreditBalanceSerializer() : AbstractSerializer<CreditBalanceMessage>(MessageComposer.CreditBalanceComposer)
{
    protected override void Serialize(IServerPacket packet, CreditBalanceMessage message)
    {
        packet.WriteString(message.credits + ".0");
    }
}
