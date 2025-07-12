﻿using System.Reflection.PortableExecutable;
using Turbo.Core.Packets.Messages;
using Turbo.Core.Packets.Revisions;
using Turbo.Packets.Incoming.Catalog;
using Turbo.Packets.Outgoing.Advertising;
using Turbo.Packets.Outgoing.Availability;
using Turbo.Packets.Outgoing.CallForHelp;
using Turbo.Packets.Outgoing.Camera;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Outgoing.Catalog.Clothing;
using Turbo.Packets.Outgoing.Competition;
using Turbo.Packets.Outgoing.FriendList;
using Turbo.Packets.Outgoing.GroupForums;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Outgoing.Inventory.Achievements;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Outgoing.Inventory.Purse;
using Turbo.Packets.Outgoing.MysteryBox;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Outgoing.Notifications;
using Turbo.Packets.Outgoing.Perk;
using Turbo.Packets.Outgoing.Preferences;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Outgoing.Room.Furniture;
using Turbo.Packets.Outgoing.Room.Layout;
using Turbo.Packets.Outgoing.Room.Permissions;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Outgoing.Tracking;
using Turbo.Packets.Outgoing.UserDefinedRoomEvents.WiredMenu;
using Turbo.Packets.Outgoing.Users;
using Turbo.WIN63202506020918587581630.Parsers.Advertising;
using Turbo.WIN63202506020918587581630.Parsers.Camera;
using Turbo.WIN63202506020918587581630.Parsers.Catalog;
using Turbo.WIN63202506020918587581630.Parsers.Competition;
using Turbo.WIN63202506020918587581630.Parsers.Friendlist;
using Turbo.WIN63202506020918587581630.Parsers.GroupForums;
using Turbo.WIN63202506020918587581630.Parsers.Handshake;
using Turbo.WIN63202506020918587581630.Parsers.Inventory.Achievements;
using Turbo.WIN63202506020918587581630.Parsers.Inventory.Badges;
using Turbo.WIN63202506020918587581630.Parsers.Inventory.Bots;
using Turbo.WIN63202506020918587581630.Parsers.Inventory.Furni;
using Turbo.WIN63202506020918587581630.Parsers.Inventory.Pets;
using Turbo.WIN63202506020918587581630.Parsers.Inventory.Purse;
using Turbo.WIN63202506020918587581630.Parsers.Navigator;
using Turbo.WIN63202506020918587581630.Parsers.NewNavigator;
using Turbo.WIN63202506020918587581630.Parsers.Nft;
using Turbo.WIN63202506020918587581630.Parsers.Notifications;
using Turbo.WIN63202506020918587581630.Parsers.Preferences;
using Turbo.WIN63202506020918587581630.Parsers.room;
using Turbo.WIN63202506020918587581630.Parsers.Room.Avatar;
using Turbo.WIN63202506020918587581630.Parsers.Room.Chat;
using Turbo.WIN63202506020918587581630.Parsers.Room.Engine;
using Turbo.WIN63202506020918587581630.Parsers.Room.Layout;
using Turbo.WIN63202506020918587581630.Parsers.RoomSettings;
using Turbo.WIN63202506020918587581630.Parsers.SoundSettings;
using Turbo.WIN63202506020918587581630.Parsers.Tracking;
using Turbo.WIN63202506020918587581630.Parsers.Users;
using Turbo.WIN63202506020918587581630.Serializer.Advertising;
using Turbo.WIN63202506020918587581630.Serializer.Availability;
using Turbo.WIN63202506020918587581630.Serializer.CallForHelp;
using Turbo.WIN63202506020918587581630.Serializer.Camera;
using Turbo.WIN63202506020918587581630.Serializer.Catalog;
using Turbo.WIN63202506020918587581630.Serializer.Catalog.Clothing;
using Turbo.WIN63202506020918587581630.Serializer.Catalog.Marketplace;
using Turbo.WIN63202506020918587581630.Serializer.Competition;
using Turbo.WIN63202506020918587581630.Serializer.FriendList;
using Turbo.WIN63202506020918587581630.Serializer.GroupForums;
using Turbo.WIN63202506020918587581630.Serializer.Handshake;
using Turbo.WIN63202506020918587581630.Serializer.Inventory.Achievements;
using Turbo.WIN63202506020918587581630.Serializer.Inventory.AvatarEffect;
using Turbo.WIN63202506020918587581630.Serializer.Inventory.Furni;
using Turbo.WIN63202506020918587581630.Serializer.Inventory.Purse;
using Turbo.WIN63202506020918587581630.Serializer.MysteryBox;
using Turbo.WIN63202506020918587581630.Serializer.Navigator;
using Turbo.WIN63202506020918587581630.Serializer.Notifications;
using Turbo.WIN63202506020918587581630.Serializer.Perk;
using Turbo.WIN63202506020918587581630.Serializer.Preferences;
using Turbo.WIN63202506020918587581630.Serializer.room;
using Turbo.WIN63202506020918587581630.Serializer.Room.Action;
using Turbo.WIN63202506020918587581630.Serializer.Room.Chat;
using Turbo.WIN63202506020918587581630.Serializer.Room.Layout;
using Turbo.WIN63202506020918587581630.Serializer.Room.Permissions;
using Turbo.WIN63202506020918587581630.Serializer.Room.Session;
using Turbo.WIN63202506020918587581630.Serializer.Tracking;
using Turbo.WIN63202506020918587581630.Serializer.User;
using Turbo.WIN63202506020918587581630.Serializer.UserDefinedRoomEvents.WiredMenu;
using Turbo.WIN63202506020918587581630.Serializers.RoomSettings;
using CanCreateRoomMessage = Turbo.Packets.Outgoing.Navigator.CanCreateRoomMessage;
using MessengerInitMessage = Turbo.Packets.Outgoing.FriendList.MessengerInitMessage;

namespace Turbo.WIN63202506020918587581630;

public class PluginRevision : IRevision
{
    public string Revision => "WIN63-202506020918-587581630";

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
        { (int)MessageEvent.SetNewNavigatorWindowPreferencesMessageEvent, new SetNewNavigatorWindowPreferencesMessageParser() },
        { (int)MessageEvent.CreateFlatMessageEvent, new CreateFlatParser() },
        { (int)MessageEvent.GetPopularRoomTagsMessageEvent, new GetPopularRoomTagsParser() },
        { (int)MessageEvent.GetGuestRoomMessageEvent, new GetGuestRoomParser() },
        { (int)MessageEvent.MyFavouriteRoomsSearchMessageEvent, new MyFavouriteRoomsSearchParser() },
        { (int)MessageEvent.MyFriendsRoomsSearchMessageEvent, new MyFriendsRoomsSearchParser() },
        { (int)MessageEvent.MyGuildBasesSearchMessageEvent, new MyGuildBasesSearchParser() },
        { (int)MessageEvent.MyRoomHistorySearchMessageEvent, new MyRoomHistorySearchParser() },
        { (int)MessageEvent.MyRoomRightsSearchMessageEvent, new MyRoomRightsSearchParser() },
        { (int)MessageEvent.MyRoomsSearchMessageEvent, new MyRoomsSearchParser() },
        { (int)MessageEvent.NavigatorAddCollapsedCategoryMessageEvent, new NavigatorAddCollapsedCategoryParser() },
        { (int)MessageEvent.NavigatorAddSavedSearchEvent, new NavigatorAddSavedSearchParser() },
        { (int)MessageEvent.NavigatorDeleteSavedSearchEvent, new NavigatorDeleteSavedSearchParser() },
        { (int)MessageEvent.NavigatorRemoveCollapsedCategoryMessageEvent, new NavigatorRemoveCollapsedCategoryParser() },
        { (int)MessageEvent.NavigatorSetSearchCodeViewModeMessageEvent, new NavigatorSetSearchCodeViewModeParser() },
        { (int)MessageEvent.PopularRoomsSearchMessageEvent, new PopularRoomsSearchMessageParser() },
        { (int)MessageEvent.RoomsWhereMyFriendsAreSearchMessageEvent, new RoomsWhereMyFriendsAreSearchParser() },
        { (int)MessageEvent.RoomsWithHighestScoreSearchMessageEvent, new RoomsWithHighestScoreSearchParser() },
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
        { (int)MessageEvent.GetBonusRareInfoMessageEvent, new GetBonusRareInfoParser() },
        { (int)MessageEvent.ChangeQueueMessageEvent, new ChangeQueueMessageParser() },
        { (int)MessageEvent.QuitMessageEvent, new QuitMessageEventParser() },
        { (int)MessageEvent.GetOccupiedTilesMessageEvent, new GetOccupiedTilesMessageParser() },
        { (int)MessageEvent.GetRoomEntryTileMessageEvent, new GetRoomEntryTileMessageParser() },
        { (int)MessageEvent.UpdateFloorPropertiesMessageEvent, new UpdateFloorPropertiesMessageParser() },
        { (int)MessageEvent.MoveAvatarMessageEvent, new MoveAvatarMessageParser() },
        { (int)MessageEvent.ChatMessageEvent, new ChatMessageParser() },
        { (int)MessageEvent.CancelTypingMessageEvent, new CancelTypingMessageParser() },
        { (int)MessageEvent.ShoutMessageEvent, new ShoutMessageParser() },
        { (int)MessageEvent.StartTypingMessageEvent, new StartTypingMessageParser() },
        { (int)MessageEvent.WhisperMessageEvent, new WhisperMessageParser() },
        { (int)MessageEvent.AddFavouriteRoomMessageEvent, new AddFavouriteRoomParser() },
        { (int)MessageEvent.DeleteFavouriteRoomMessageEvent, new DeleteFavouriteRoomParser() },

        //Catalog
        { (int)MessageEvent.GetCatalogIndexEvent, new GetCatalogIndexParser() },
        { (int)MessageEvent.GetCatalogPageEvent, new GetCatalogPageParser() },
        { (int)MessageEvent.GetProductOfferEvent, new GetProductOfferParser() },
        { (int)MessageEvent.PurchaseFromCatalogEvent, new PurchaseFromCatalogParser() },
        { (int)MessageEvent.BuildersClubQueryFurniCountMessageEvent, new BuildersClubQueryFurniCountParser() },
        { (int)MessageEvent.GetGiftWrappingConfigurationEvent, new GetGiftWrappingConfigurationParser() },
        { (int)MessageEvent.GetBundleDiscountRulesetEvent, new GetBundleDiscountRulesetParser() },
        { (int)MessageEvent.GetMarketplaceConfigurationMessageEvent, new GetMarketplaceConfigurationMessageParser() },

        //Camera
        { (int)MessageEvent.RequestCameraConfigurationMessageEvent, new RequestCameraConfigurationMessageParser() },

        //Competition
        { (int)MessageEvent.RoomCompetitionInitMessageEvent, new RoomCompetitionInitMessageParser() },

        //Inventory Achievements
        { (int)MessageEvent.GetAchievementsEvent, new GetAchievementsParser() },

        //Inventory Furni
        { (int)MessageEvent.RequestFurniInventoryWhenNotInRoomEvent, new RequestFurniInventoryWhenNotInRoomParser() },

        //Inventory Pets
        { (int)MessageEvent.GetPetInventoryEvent, new GetPetInventoryParser() },

        //Inventory Badges
        { (int)MessageEvent.GetBadgesEvent, new GetBadgesParser() },

        //Inventory Bots
        { (int)MessageEvent.GetBotInventoryEvent, new GetBotInventoryParser() },

        //Preferences
        { (int)MessageEvent.SetUIFlagsMessageEvent, new SetUIFlagsMessageParser() },
        
        //Room Avatar
        { (int)MessageEvent.AvatarExpressionMessageEvent, new AvatarExpressionMessageParser() },
        { (int)MessageEvent.ChangePostureMessageEvent, new ChangePostureMessageParser() },
        { (int)MessageEvent.DanceMessageEvent, new DanceMessageParser() },
        { (int)MessageEvent.LookToMessageEvent, new LookToMessageParser() },
        { (int)MessageEvent.SignMessageEvent, new SignMessageParser() },

        //Room Engine
        { (int)MessageEvent.ClickFurniMessageEvent, new ClickFurniMessageParser() },
        { (int)MessageEvent.PlaceObjectMessageEvent, new PlaceObjectMessageParser() },
        { (int)MessageEvent.PickupObjectMessageEvent, new PickupObjectMessageParser() },
        { (int)MessageEvent.MoveObjectMessageEvent, new MoveObjectMessageParser() },

        //RoomSettings
        { (int)MessageEvent.GetRoomSettingsMessageEvent, new GetRoomSettingsMessageParser() },

        //Notifications
        { (int)MessageEvent.ResetUnseenItemsEvent, new ResetUnseenItemsParser() },

        //Users
        { (int)MessageEvent.GetHabboGroupBadgesMessageEvent, new GetHabboGroupBadgesMessageParser() },
        { (int)MessageEvent.GetExtendedProfileMessageEvent, new GetExtendedProfileMessageParser() },
        { (int)MessageEvent.GetRelationshipStatusInfoMessageEvent, new GetRelationshipStatusInfoMessageParser() },
        { (int)MessageEvent.GetSelectedBadgesMessageEvent, new GetSelectedBadgesMessageParser() }
    };

    public IDictionary<Type, ISerializer> Serializers { get; } = new Dictionary<Type, ISerializer>
    {
        { typeof(InitDiffieHandshakeComposer), new InitDiffieHandshakeSerializer() },
        { typeof(CompleteDiffieHandshakeComposer), new CompleteDiffieHandshakeSerializer() },
        { typeof(AuthenticationOKMessage), new AuthenticationOKMessageSerializer() },
        { typeof(AvatarEffectMessage), new AvatarEffectsSerializer() },
        { typeof(FavouritesMessage), new FavouritesSerializer() },
        { typeof(FavouriteChangedMessage), new FavouriteChangedMessageSerializer() },
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
        { typeof(RoomReadyMessage), new RoomReadyMessageSerializer() },
        { typeof(RoomPropertyMessage), new RoomPropertyMessageSerializer() },
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
        { typeof(RoomVisualizationSettingsMessage), new RoomVisualizationSettingsMessageSerializer() },
        { typeof(UsersMessage), new UsersMessageSerializer() },
        { typeof(UserUpdateMessage), new UserUpdateMessageSerializer() },
        { typeof(UserRemoveMessage), new UserRemoveMessageSerializer() },
        { typeof(UserChangeMessage), new UserChangeMessageSerializer() },
        { typeof(FavouriteMembershipUpdateMessage), new FavouriteMembershipUpdateMessageSerializer() },
        { typeof(HeightMapUpdateMessage), new HeightMapUpdateMessageSerializer() },
        { typeof(ItemAddMessage), new ItemAddMessageSerializer() },
        { typeof(ItemDataUpdateMessage), new ItemDataUpdateMessageSerializer() },
        { typeof(ItemRemoveMessage), new ItemRemoveMessageSerializer() },
        { typeof(ItemsMessage), new ItemsMessageSerializer() },
        { typeof(ItemUpdateMessage), new ItemUpdateMessageSerializer() },
        { typeof(ObjectAddMessage), new ObjectAddMessageSerializer() },
        { typeof(ObjectDataUpdateMessage), new ObjectDataUpdateMessageSerializer() },
        { typeof(ObjectRemoveMessage), new ObjectRemoveMessageSerializer() },
        { typeof(ObjectsDataUpdateMessage), new ObjectsDataUpdateMessageSerializer() },
        { typeof(ObjectsMessage), new ObjectsMessageSerializer() },
        { typeof(ObjectUpdateMessage), new ObjectUpdateMessageSerializer() },
        { typeof(RoomEntryInfoMessage), new RoomEntryInfoMessageSerializer() },
        { typeof(SlideObjectBundleMessage), new SlideObjectBundleMessageSerializer() },
        { typeof(ChatMessage), new ChatMessageSerializer() },
        { typeof(WhisperMessage), new WhisperMessageSerializer() },
        { typeof(ShoutMessage), new ShoutMessageSerializer() },
        { typeof(FloodControlMessage), new FloodControlMessageSerializer() },
        { typeof(RemainingMutePeriodMessageSerializer), new RemainingMutePeriodMessageSerializer() },
        { typeof(RoomChatSettingsMessage), new RoomChatSettingsMessageSerializer() },
        { typeof(RoomFilterSettingsMessage), new RoomFilterSettingsMessageSerializer() },
        { typeof(UserTypingMessage), new UserTypingMessageSerializer() },
        { typeof(FlatCreatedMessage), new FlatCreatedSerializer() },
        { typeof(CanCreateRoomMessage), new CanCreateRoomSerializer() },

        //Camera
        { typeof(InitCameraMessage), new InitCameraMessageSerializer() },

        //Navigator
        { typeof(RoomRatingMessage), new RoomRatingSerializer() },
        { typeof(RoomEventMessage), new RoomEventSerializer() },

        //Catalog
        { typeof(CatalogIndexMessage), new CatalogIndexSerializer() },
        { typeof(CatalogPageMessage), new CatalogPageSerializer() },
        { typeof(ProductOfferMessage), new ProductOfferSerializer() },
        { typeof(PurchaseErrorMessage), new PurchaseErrorSerializer() },
        { typeof(PurchaseNotAllowedMessage), new PurchaseNotAllowedSerializer() },
        { typeof(PurchaseOkMessage), new PurchaseOkSerializer() },
        { typeof(PresentOpenedMessage), new PresentOpenedMessageSerializer() },
        { typeof(MarketplaceConfigurationMessage), new MarketplaceConfigurationSerializer() },
        { typeof(YouAreOwnerMessage), new YouAreOwnerSerializer() },

        //Inventory Achievements
        { typeof(AchievementsMessage), new AchievementsSerializer() },

        //Inventory Furni
        { typeof(FurniListMessage), new FurniListSerializer() },
        { typeof(FurniListRemoveMessage), new FurniListRemoveSerializer() },
        { typeof(FurniListAddOrUpdateMessage), new FurniListAddOrUpdateSerializer() },

        //GroupForums
        { typeof(HabboGroupBadgesMessage), new HabboGroupBadgesMessageSerializer() },

        //Notifications
        { typeof(UnseenItemsMessage), new UnseenItemsSerializer() },

        //Rooms Actions
        { typeof(DanceMessage), new DanceMessageSerializer() },
        { typeof(ExpressionMessage), new ExpressionMessageSerializer() },
        { typeof(SleepMessage), new SleepMessageSerializer() },

        //Room Session
        { typeof(HanditemConfigurationMessage), new HanditemConfigurationMessageSerializer() },

        //RoomSettings
        { typeof(RoomSettingsDataMessage), new RoomSettingsDataMessageSerializer() },

        //Users
        { typeof(ExtendedProfileMessage), new ExtendedProfileMessageSerializer() },
        { typeof(UserBadgesMessage), new UserBadgesMessageSerializer() },
        { typeof(RelationshipStatusInfoMessage), new RelationshipStatusInfoSerializer() },

        //UserDefinedRoomEvents WiredMenu
        {  typeof(WiredPermissionsMessage), new WiredPermissionsSerializer() }

        //MISSING PACKETS
        //2602	VersionCheckMessageComposer
        //1390	UniqueIDMessageComposer
        //3967	Game2GetAccountGameStatusMessageComposer
    };
}