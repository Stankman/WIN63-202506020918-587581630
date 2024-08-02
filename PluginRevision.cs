using Turbo.Core.Packets.Messages;
using Turbo.Core.Packets.Revisions;
using Turbo.Packets.Outgoing.Advertising;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Outgoing.Availability;
using Turbo.Packets.Outgoing.Competition;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Outgoing.Tracking;
using Turbo.WIN63202407091256704579380.Parsers.Advertising;
using Turbo.WIN63202407091256704579380.Parsers.Catalog;
using Turbo.WIN63202407091256704579380.Parsers.Competition;
using Turbo.WIN63202407091256704579380.Parsers.Friendlist;
using Turbo.WIN63202407091256704579380.Parsers.GroupForums;
using Turbo.WIN63202407091256704579380.Parsers.Handshake;
using Turbo.WIN63202407091256704579380.Parsers.Inventory.Badges;
using Turbo.WIN63202407091256704579380.Parsers.Inventory.Purse;
using Turbo.WIN63202407091256704579380.Parsers.NewNavigator;
using Turbo.WIN63202407091256704579380.Parsers.Nft;
using Turbo.WIN63202407091256704579380.Parsers.SoundSettings;
using Turbo.WIN63202407091256704579380.Parsers.Tracking;
using Turbo.WIN63202407091256704579380.Parsers.Users;
using Turbo.WIN63202407091256704579380.Serializer.Advertising;
using Turbo.WIN63202407091256704579380.Serializer.Availability;
using Turbo.WIN63202407091256704579380.Serializer.Competition;
using Turbo.WIN63202407091256704579380.Serializer.Handshake;
using Turbo.WIN63202407091256704579380.Serializer.Navigator;
using Turbo.WIN63202407091256704579380.Serializer.Tracking;

namespace Turbo.WIN63202407091256704579380;

public class PluginRevision : IRevision
{
    public string Revision => "WIN63-202407091256-704579380";

    public IDictionary<int, IParser> Parsers { get; } = new Dictionary<int, IParser>
    {
        { (int)MessageEvent.ClientHelloMessageEvent, new ClientHelloParser() },
        { (int)MessageEvent.InitDiffieHandshakeMessageEvent, new InitDiffieHandshakeMessageParser() },
        { (int)MessageEvent.CompleteDiffieHandshakeMessageEvent, new CompleteDiffieHandshakeMessageParser() },
        { (int)MessageEvent.SSOTicketMessageEvent, new SSOTicketMessageParser() },
        { (int)MessageEvent.InfoRetrieveMessageEvent, new InfoRetrieveMessageParser() },
        { (int)MessageEvent.EventLogMessageEvent, new EventLogMessageParser() },
        { (int)MessageEvent.GetIgnoredUsersMessageEvent, new GetIgnoredUsersMessageParser() },
        { (int)MessageEvent.UserNftChatStylesMessageEvent, new GetUserNftChatStylesMessageParser() },
        { (int)MessageEvent.GetMOTDMessageEvent, new GetMOTDMessageParser() },
        { (int)MessageEvent.MessengerInitMessageEvent, new MessengerInitMessageParser() },
        { (int)MessageEvent.NewNavigatorInitEvent, new NewNavigatorInitParser() },
        { (int)MessageEvent.GetCreditsInfoEvent, new GetCreditsInfoParser() },
        { (int)MessageEvent.GetNftCreditsMessageEvent, new GetNftCreditsMessageParser() },
        { (int)MessageEvent.GetSilverMessageEvent, new GetSilverMessageParser() },
        { (int)MessageEvent.ScrGetUserInfoMessageEvent, new ScrGetUserInfoMessageParser() },
        { (int)MessageEvent.GetBadgePointLimitsEvent, new GetBadgePointLimitsParser() },
        { (int)MessageEvent.GetSoundSettingsEvent, new GetSoundSettingsParser() },
        { (int)MessageEvent.GetUnreadForumsCountMessageEvent, new GetUnreadForumsCountMessageParser() },
        { (int)MessageEvent.GetNextTargetedOfferEvent, new GetNextTargetedOfferParser() },
        { (int)MessageEvent.LatencyPingRequestMessageEvent, new LatencyPingRequestMessageParser() },
        { (int)MessageEvent.GetCurrentTimingCodeMessageEvent, new GetCurrentTimingCodeMessageParser() },
        { (int)MessageEvent.GetInterstitialMessageEvent, new GetInterstitialMessageParser() },
        { (int)MessageEvent.InterstitialShownMessageEvent, new InterstitialShownMessageParser() },
        { (int)MessageEvent.LatencyPingReportMessageEvent, new LatencyPingReportMessageParser() },
        { (int)MessageEvent.PongMessageEvent, new PongMessageParser() },
        { (int)MessageEvent.PerformanceLogMessageEvent, new PerformanceLogMessageParser()},
        { (int)MessageEvent.LagWarningReportMessageEvent, new LagWarningReportMessageParser()}
    };

    public IDictionary<Type, ISerializer> Serializers { get; } = new Dictionary<Type, ISerializer>
    {
        { typeof(InitDiffieHandshakeComposer), new InitDiffieHandshakeSerializer() },
        { typeof(CompleteDiffieHandshakeComposer), new CompleteDiffieHandshakeSerializer() },
        { typeof(AuthenticationOKMessage), new AuthenticationOKMessageSerializer() },
        { typeof(UserRightsMessage), new UserRightsMessageSerializer() },
        { typeof(AvailabilityStatusMessage), new AvailabilityStatusMessageSerializer() },
        { typeof(NavigatorSettingsMessage), new NavigatorSettingsSerializer() },
        { typeof(CurrentTimingCodeMessage), new CurrentTimingCodeMessageSerializer() },
        { typeof(UserObjectMessage), new UserObjectMessageSerializer() },
        { typeof(InterstitialMessage), new InterstitialMessageSerializer() },
        { typeof(LatencyPingResponseMessage), new LatencyPingResponseMessageSerializer() },
        { typeof(PingMessage), new PingMessageSerializer() }
    };
}