using Microsoft.Extensions.Logging;
using Turbo.Core.Plugins;
using Turbo.Packets.Revisions;

namespace Turbo.WIN63202407091256704579380;

public class Revision704579380Plugin : ITurboPlugin
{
    public string PluginName => "REV-WIN63-202407091256-704579380";
    public string PluginAuthor => "dotmbf";

    public Revision704579380Plugin(
        IRevisionManager revisionManager,
        ILogger<Revision704579380Plugin> logger
    )
    {
        var myRevision = new PluginRevision();
        revisionManager.Revisions.Add(myRevision.Revision, myRevision);

        revisionManager.DefaultRevision = myRevision;

        logger.LogInformation("{} - Registered revision: {}", nameof(Revision704579380Plugin), myRevision.Revision);
    }
}