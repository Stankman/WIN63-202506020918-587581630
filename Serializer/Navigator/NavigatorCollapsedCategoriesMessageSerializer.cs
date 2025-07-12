using Turbo.Core.Packets.Messages;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Serializers;

namespace Turbo.WIN63202506020918587581630.Serializer.Navigator;

public class NavigatorCollapsedCategoriesMessageSerializer() : AbstractSerializer<NavigatorCollapsedCategoriesMessage>(MessageComposer.NavigatorCollapsedCategoriesMessageComposer)
{
    protected override void Serialize(IServerPacket packet, NavigatorCollapsedCategoriesMessage message)
    {
        packet.WriteInteger(message.CollapsedCategories.Count);

        foreach (var category in message.CollapsedCategories)
        {
            packet.WriteString(category);
        }
    }
}