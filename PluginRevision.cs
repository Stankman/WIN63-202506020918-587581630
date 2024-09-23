using Turbo.Core.Packets.Messages;
using Turbo.Core.Packets.Revisions;
using Turbo.Packets.Incoming.FriendList;
using Turbo.Packets.Incoming.Navigator;
using Turbo.Packets.Outgoing.Advertising;
using Turbo.Packets.Incoming.Tracking;
using Turbo.Packets.Outgoing.Availability;
using Turbo.Packets.Outgoing.Competition;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Outgoing.Room.Permissions;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Outgoing.Tracking;
using Turbo.WIN63202407091256704579380.Parsers.Advertising;
using Turbo.WIN63202407091256704579380.Parsers.Catalog;
using Turbo.WIN63202407091256704579380.Parsers.Competition;
using Turbo.WIN63202407091256704579380.Parsers.Friendlist;
using Turbo.WIN63202407091256704579380.Parsers.GroupForums;
using Turbo.WIN63202407091256704579380.Parsers.Handshake;
using Turbo.WIN63202407091256704579380.Parsers.Inventory.Badges;
using Turbo.WIN63202407091256704579380.Parsers.Inventory.Purse;
using Turbo.WIN63202407091256704579380.Parsers.Navigator;
using Turbo.WIN63202407091256704579380.Parsers.NewNavigator;
using Turbo.WIN63202407091256704579380.Parsers.Nft;
using Turbo.WIN63202407091256704579380.Parsers.room;
using Turbo.WIN63202407091256704579380.Parsers.SoundSettings;
using Turbo.WIN63202407091256704579380.Parsers.Tracking;
using Turbo.WIN63202407091256704579380.Parsers.Users;
using Turbo.WIN63202407091256704579380.Serializer.Advertising;
using Turbo.WIN63202407091256704579380.Serializer.Availability;
using Turbo.WIN63202407091256704579380.Serializer.Competition;
using Turbo.WIN63202407091256704579380.Serializer.Handshake;
using Turbo.WIN63202407091256704579380.Serializer.Navigator;
using Turbo.WIN63202407091256704579380.Serializer.room;
using Turbo.WIN63202407091256704579380.Serializer.Tracking;
using Turbo.WIN63202407091256704579380.Serializer.Inventory.AvatarEffect;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Outgoing.Users;
using Turbo.WIN63202407091256704579380.Serializer.User;
using Turbo.Packets.Outgoing.Notifications;
using Turbo.Packets.Outgoing.Catalog.Clothing;
using Turbo.WIN63202407091256704579380.Serializer.Catalog.Clothing;
using Turbo.WIN63202407091256704579380.Serializer.Notifications;
using Turbo.Packets.Outgoing.Inventory.Achievements;
using Turbo.WIN63202407091256704579380.Serializer.Inventory.Achievements;
using Turbo.Packets.Outgoing.MysteryBox;
using Turbo.WIN63202407091256704579380.Serializer.MysteryBox;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.WIN63202407091256704579380.Serializer.Catalog;
using Turbo.Packets.Outgoing.CallForHelp;
using Turbo.WIN63202407091256704579380.Serializer.CallForHelp;
using Turbo.Packets.Outgoing.Inventory.Purse;
using Turbo.WIN63202407091256704579380.Serializer.Inventory.Purse;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.WIN63202407091256704579380.Serializer.FriendList;
using Turbo.Packets.Incoming.Nft;
using Turbo.Packets.Outgoing.Preferences;
using Turbo.Packets.Outgoing.Room.Layout;
using Turbo.WIN63202407091256704579380.Parsers.Room.Layout;
using Turbo.WIN63202407091256704579380.Serializer.Preferences;
using Turbo.WIN63202407091256704579380.Serializer.Room.Layout;
using MessengerInitMessage = Turbo.Packets.Outgoing.FriendList.MessengerInitMessage;
using Turbo.WIN63202407091256704579380.Serializer.Perk;
using Turbo.Packets.Outgoing.Perk;

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
        { (int)MessageEvent.GetUserNftChatStylesMessageEvent, new GetUserNftChatStylesMessageParser() },
        { (int)MessageEvent.GetMOTDMessageEvent, new GetMOTDMessageParser() },
        { (int)MessageEvent.MessengerInitMessageEvent, new MessengerInitMessageParser() },
        { (int)MessageEvent.NewNavigatorInitEvent, new NewNavigatorInitParser() },
        { (int)MessageEvent.NewNavigatorSearchEvent, new NewNavigatorSearchParser() },
        { (int)MessageEvent.GetUserFlatCatsMessageEvent, new GetUserFlatCatsParser() },
        { (int)MessageEvent.GetUserEventCatsMessageEvent, new GetUserEventCatsParser() },
        { (int)MessageEvent.CanCreateRoomMessageEvent, new CanCreateRoomParser() },
        { (int)MessageEvent.ForwardToSomeRoomMessageEvent, new ForwardToSomeRoomParser() },
        { (int)MessageEvent.SetNewNavigatorWindowPreferencesMessageEvent, new SetNewNavigatorWindowPreferencesMessageParser()},
        { (int)MessageEvent.CreateFlatMessageEvent, new CreateFlatParser()},
        { (int)MessageEvent.GetPopularRoomTagsMessageEvent, new GetPopularRoomTagsParser()},
        { (int)MessageEvent.GetGuestRoomMessageEvent, new GetGuestRoomParser()},
        { (int)MessageEvent.MyFavouriteRoomsSearchMessageEvent, new MyFavouriteRoomsSearchParser()},
        { (int)MessageEvent.MyFriendsRoomsSearchMessageEvent, new MyFriendsRoomsSearchParser()},
        { (int)MessageEvent.MyGuildBasesSearchMessageEvent, new MyGuildBasesSearchParser()},
        { (int)MessageEvent.MyRoomHistorySearchMessageEvent, new MyRoomHistorySearchParser()},
        { (int)MessageEvent.MyRoomRightsSearchMessageEvent, new MyRoomRightsSearchParser()},
        { (int)MessageEvent.MyRoomsSearchMessageEvent, new MyRoomsSearchParser()},
        { (int)MessageEvent.NavigatorAddCollapsedCategoryMessageEvent, new NavigatorAddCollapsedCategoryParser()},
        { (int)MessageEvent.NavigatorAddSavedSearchEvent, new NavigatorAddSavedSearchParser()},
        { (int)MessageEvent.NavigatorDeleteSavedSearchEvent, new NavigatorDeleteSavedSearchParser()},
        { (int)MessageEvent.NavigatorRemoveCollapsedCategoryMessageEvent, new NavigatorRemoveCollapsedCategoryParser()},
        { (int)MessageEvent.NavigatorSetSearchCodeViewModeMessageEvent, new NavigatorSetSearchCodeViewModeParser()},
        { (int)MessageEvent.PopularRoomsSearchMessageEvent, new PopularRoomsSearchMessageParser()},
        { (int)MessageEvent.RoomsWhereMyFriendsAreSearchMessageEvent, new RoomsWhereMyFriendsAreSearchParser()},
        { (int)MessageEvent.RoomsWithHighestScoreSearchMessageEvent, new RoomsWithHighestScoreSearchParser()},
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
        { (int)MessageEvent.LatencyPingReportMessageEvent, new LatencyPingReportMessageParser() },
        { (int)MessageEvent.PongMessageEvent, new PongMessageParser() },
        { (int)MessageEvent.PerformanceLogMessageEvent, new PerformanceLogMessageParser() },
        { (int)MessageEvent.LagWarningReportMessageEvent, new LagWarningReportMessageParser() },
        { (int)MessageEvent.OpenFlatConnectionMessageEvent, new OpenFlatConnectionMessageParser() },
        { (int)MessageEvent.InterstitialShownMessageEvent, new InterstitialShownMessageParser() },
        { (int)MessageEvent.GetFurnitureAliasesMessageEvent, new GetFurnitureAliasesMessageParser() },
        { (int)MessageEvent.GetHeightMapMessageEvent, new GetHeightMapMessageParser() },
        { (int)MessageEvent.GetBonusRareInfoMessageEvent, new GetBonusRareInfoParser() },
        { (int)MessageEvent.ChangeQueueMessageEvent, new ChangeQueueMessageParser()},
        { (int)MessageEvent.QuitMessageEvent, new QuitMessageEventParser()},
        { (int)MessageEvent.GetOccupiedTilesMessageEvent, new GetOccupiedTilesMessageParser() },
        { (int)MessageEvent.GetRoomEntryTileMessageEvent, new GetRoomEntryTileMessageParser() },
        { (int)MessageEvent.UpdateFloorPropertiesMessageEvent, new UpdateFloorPropertiesMessageParser() }
    };

    public IDictionary<Type, ISerializer> Serializers { get; } = new Dictionary<Type, ISerializer>
    {
        { typeof(InitDiffieHandshakeComposer), new InitDiffieHandshakeSerializer() },
        { typeof(CompleteDiffieHandshakeComposer), new CompleteDiffieHandshakeSerializer() },
        { typeof(AuthenticationOKMessage), new AuthenticationOKMessageSerializer() },
        { typeof(AvatarEffectMessage), new AvatarEffectsSerializer() },
        { typeof(FavouritesMessage), new FavouritesSerializer() },
        { typeof(ScrSendUserInfoMessage), new ScrSendUserInfoSerializer() },
        { typeof(FigureSetIdsMessage), new FigureSetIdsSerializer() },
        { typeof(NoobnessLevelMessage), new NoobnessLevelSerializer() },
        { typeof(UserRightsMessage), new UserRightsMessageSerializer() },
        { typeof(AvailabilityStatusMessage), new AvailabilityStatusMessageSerializer() },
        { typeof(InfoFeedEnableMessage), new InfoFeedEnableMessageSerializer() },
        { typeof(ActivityPointsMessage), new ActivityPointsSerializer() },
        { typeof(AchievementsScoreMessage), new AchievementsScoreSerializer() },
        { typeof(NavigatorSettingsMessage), new NavigatorSettingsSerializer() },
        { typeof(NewNavigatorPreferencesMessage), new NewNavigatorPreferencesSerializer() },
        { typeof(CurrentTimingCodeMessage), new CurrentTimingCodeMessageSerializer() },
        { typeof(UserObjectMessage), new UserObjectMessageSerializer() },
        { typeof(IsFirstLoginOfDayMessage), new IsFirstLoginOfDaySerializer() },
        { typeof(MysteryBoxKeysMessage), new MysteryBoxKeysSerializer() },
        { typeof(BuildersClubSubscriptionStatusMessage), new BuildersClubSubscriptionStatusSerializer() },
        { typeof(CfhTopicsInitMessage), new CfhTopicsInitSerializer() },
        { typeof(LatencyPingResponseMessage), new LatencyPingResponseMessageSerializer() },
        { typeof(PingMessage), new PingMessageSerializer() },
        { typeof(OpenConnectionMessage), new OpenConnectionMessageSerializer() },
        { typeof(InterstitialMessage), new InterstitialMessageSerializer() },
        { typeof(RoomReadyMessage), new RoomReadyMessageSerializer()},
        { typeof(RoomPropertyMessage), new RoomPropertyMessageSerializer()},
        { typeof(YouAreControllerMessage), new YouAreControllerMessageSerializer() },
        { typeof(FurnitureAliasesMessage), new FurnitureAliasesMessageSerializer() },
        { typeof(GetGuestRoomResultMessage), new GetGuestRoomResultSerializer() },
        { typeof(UserFlatCatsMessage), new UserFlatCatsSerializer() },
        { typeof(UserEventCatsMessage), new UserEventCatsSerializer() },
        { typeof(NavigatorLiftedRoomsMessage), new NavigatorLiftedRoomsSerializer() },
        { typeof(NavigatorMetaDataMessage), new NavigatorMetaDataSerializer() },
        { typeof(NavigatorSavedSearchesMessage), new NavigatorSavedSearchesSerializer() },
        { typeof(NavigatorEventCategoriesMessage), new NavigatorEventCategoriesSerializer() },
        { typeof(NavigatorCollapsedCategoriesMessage), new NavigatorCollapsedCategoriesMessageSerializer() },
        { typeof(GuestRoomSearchResultMessage), new GuestRoomSearchResultSerializer() },
        { typeof(NavigatorSearchResultBlocksMessage), new NavigatorSearchResultBlocksSerializer() },
        { typeof(CreditBalanceMessage), new CreditBalanceSerializer() },
        { typeof(BonusRareInfoMessage), new BonusRareInfoSerializer() },
        { typeof(MessengerInitMessage), new MessengerInitSerializer() },
        { typeof(FriendListFragmentMessage), new FriendListFragmentSerializer() },
        { typeof(AccountPreferencesMessage), new AccountPreferencesSerializer() },
        { typeof(CantConnectMessage), new CantConnectMessageSerializer() },
        { typeof(CloseConnectionMessage), new CloseConnectionMessageSerializer() },
        { typeof(FlatAccessibleMessage), new FlatAccessibleMessageSerializer() },
        { typeof(GamePlayerValueMessage), new GamePlayerValueMessageSerializer() },
        { typeof(GetRoomAdPurchaseInfoMessage), new GetRoomAdPurchaseInfoSerializer() },
        { typeof(RoomForwardMessage), new RoomForwardMessageSerializer() },
        { typeof(RoomQueueStatusMessage), new RoomQueueStatusMessageSerializer() },
        { typeof(YouAreNotSpectatorMessage), new YouAreNotSpectatorMessageSerializer() },
        { typeof(YouArePlayingGameMessage), new YouArePlayingGameMessageSerializer() },
        { typeof(YouAreSpectatorMessage), new YouAreSpectatorMessageSerializer() },
        { typeof(RoomEntryTileMessage), new RoomEntryTileMessageSerializer() },
        { typeof(RoomOccupiedTilesMessage), new RoomOccupiedTilesMessageSerializer() },
        { typeof(PerkAllowancesMessage), new PerkAllowancesMessageSerializer() },
        { typeof(HeightMapMessage), new HeightMapMessageSerializer() },
        { typeof(FloorHeightMapMessage), new FloorHeightMapMessageSerializer() },
        {typeof(RoomVisualizationSettingsMessage), new RoomVisualizationSettingsMessageSerializer() }
    };
}