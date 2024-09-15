using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202407091256704579380.Serializer.Navigator;

public class NavigatorMetaDataSerializer() : AbstractSerializer<NavigatorMetaDataMessage>(MessageComposer.NavigatorMetaDataComposer)
{
    protected override void Serialize(IServerPacket packet, NavigatorMetaDataMessage message)
    {
        if (message.TopLevelContexts.Count == 0)
        {
            packet.WriteInteger(0);
        }
        else
        {
            packet.WriteInteger(message.TopLevelContexts.Count);

            foreach (var context in message.TopLevelContexts)
            {
                packet.WriteString(context.SearchCode);
                packet.WriteInteger(context.SavedSearches.Count);

                foreach (var savedSearch in context.SavedSearches)
                {
                    packet.WriteInteger(savedSearch.Id);
                    packet.WriteString(savedSearch.SearchCode);
                    packet.WriteString(savedSearch.Filter);
                    packet.WriteString(savedSearch.Localization);
                }
            }
        }
    }
}