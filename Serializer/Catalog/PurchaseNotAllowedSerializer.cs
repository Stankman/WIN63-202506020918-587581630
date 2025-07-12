﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Catalog;
public class PurchaseNotAllowedSerializer() : AbstractSerializer<PurchaseNotAllowedMessage>(MessageComposer.PurchaseNotAllowedMessageComposer)
{
    protected override void Serialize(IServerPacket packet, PurchaseNotAllowedMessage message)
    {
        packet.WriteInteger((int) message.ErrorCode);
    }
}
