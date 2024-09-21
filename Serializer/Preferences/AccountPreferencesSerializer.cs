using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Preferences;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Preferences;
public class AccountPreferencesSerializer() : AbstractSerializer<AccountPreferencesMessage>(MessageComposer.AccountPreferencesComposer)
{
    protected override void Serialize(IServerPacket packet, AccountPreferencesMessage message)
    {
        packet.WriteInteger(75);
        packet.WriteInteger(75);
        packet.WriteInteger(75);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteString("");
    }
}