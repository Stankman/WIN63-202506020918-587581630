using Microsoft.Extensions.Logging;
using Turbo.Core.Plugins;
using Turbo.Packets.Revisions;

namespace Turbo.WIN63202506020918587581630;

public class Revision587581630Plugin : ITurboPlugin
{
    public string PluginName => "REV-WIN63-202506020918-587581630";
    public string PluginAuthor => "dotmbf";

    public Revision587581630Plugin(
        IRevisionManager revisionManager,
        ILogger<Revision587581630Plugin> logger
    )
    {
        var myRevision = new PluginRevision();
        revisionManager.Revisions.Add(myRevision.Revision, myRevision);

        revisionManager.DefaultRevision = myRevision;

        logger.LogInformation("{} - Registered revision: {}", nameof(Revision587581630Plugin), myRevision.Revision);
    }
}