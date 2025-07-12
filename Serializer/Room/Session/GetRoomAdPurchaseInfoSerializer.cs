﻿using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Parsers.room;

public class GetRoomAdPurchaseInfoSerializer() : AbstractSerializer<GetRoomAdPurchaseInfoMessage>(MessageComposer.RoomAdPurchaseInfoComposer)
{
    protected override void Serialize(IServerPacket packet, GetRoomAdPurchaseInfoMessage message)
    {
        packet.WriteBoolean(message.isHanditemControlBlocked);
    }
}