using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;
public class FavouritesSerializer() : AbstractSerializer<FavouritesMessage>(MessageComposer.FavouritesComposer)
{
    protected override void Serialize(IServerPacket packet, FavouritesMessage message)
    {
        packet.WriteInteger(30);
        packet.WriteInteger(0);
    }
}
