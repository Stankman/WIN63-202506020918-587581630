using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Perk;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Perk;

public class PerkAllowancesMessageSerializer () : AbstractSerializer<PerkAllowancesMessage>(MessageComposer.PerkAllowancesMessageComposer)
{
    protected override void Serialize(IServerPacket packet, PerkAllowancesMessage message)
    {
        packet.WriteInteger(13);

        packet.WriteString("USE_GUIDE_TOOL");
        packet.WriteString("");
        packet.WriteBoolean(true);

        packet.WriteString("CALL_ON_HELPERS");
        packet.WriteString("");
        packet.WriteBoolean(true);        
        
        packet.WriteString("MOUSE_ZOOM");
        packet.WriteString("");
        packet.WriteBoolean(true);

        packet.WriteString("NAVIGATOR_PHASE_TWO_2014");
        packet.WriteString("");
        packet.WriteBoolean(true);        
        
        packet.WriteString("HABBO_CLUB_OFFER_BETA");
        packet.WriteString("");
        packet.WriteBoolean(true);

        packet.WriteString("VOTE_IN_COMPETITIONS");
        packet.WriteString("");
        packet.WriteBoolean(true);

        packet.WriteString("TRADE");
        packet.WriteString("");
        packet.WriteBoolean(true);

        packet.WriteString("BUILDER_AT_WORK");
        packet.WriteString("");
        packet.WriteBoolean(false);        
        
        packet.WriteString("NAVIGATOR_ROOM_THUMBNAIL_CAMERA");
        packet.WriteString("");
        packet.WriteBoolean(true);

        packet.WriteString("CAMERA");
        packet.WriteString("");
        packet.WriteBoolean(true);        
        
        packet.WriteString("UNITY_TRADE");
        packet.WriteString("");
        packet.WriteBoolean(true);

        packet.WriteString("CITIZEN");
        packet.WriteString("");
        packet.WriteBoolean(true);

        packet.WriteString("JUDGE_CHAT_REVIEWS");
        packet.WriteString("requirement.unfulfilled.helper_level_6");
        packet.WriteBoolean(false);
    }
}
