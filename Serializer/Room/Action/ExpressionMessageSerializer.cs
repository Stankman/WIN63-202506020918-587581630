﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Room.Action;
public class ExpressionMessageSerializer() : AbstractSerializer<ExpressionMessage>(MessageComposer.ExpressionMessageComposer)
{
    protected override void Serialize(IServerPacket packet, ExpressionMessage message)
    {
        packet.WriteInteger(message.ObjectId);
        packet.WriteInteger(message.ExpressionType);
    }
}