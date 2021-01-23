/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using NPF;
using NPF.User;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HttpHelper
	{
		// Fields
		private const int retryExpireTime = 7200;
		private static Action onCloseCallback;
		private static bool afterSignup;
		private static long request_id;
		private static bool isHttpManagerGetErrorCodeFuncInitialized;
	
		// Properties
		public static Action OnCloseCallback { get; set; }
	
		// Nested types
		public static class HttpTask<T1, T2>
		{
			// Fields
			public static Func<T1, Action<T2>, Action<ErrorType, int, T2>, IHttpTask> Create;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0<T1, T2>
			where T2 : class
		{
			// Fields
			public bool createOnConnectCanvas;
			public Action<T2> onSuccess;
			public Action<ErrorType, int> onError;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _Send_b__1(T2 res);
			internal void _Send_b__2(ErrorType type, int n, T2 r);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_1<T1, T2>
			where T2 : class
		{
			// Fields
			public long token;
			public __c__DisplayClass14_0<T1, T2> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass14_1();
	
			// Methods
			internal void _Send_b__3(ErrorType type, int n, T2 r);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__14<T1, T2>
			where T2 : class
		{
			// Fields
			public static readonly __c__14<T1, T2> __9;
			public static Func<string, Dictionary<string, string>, int> __9__14_0;
	
			// Constructors
			static __c__14();
			public __c__14();
	
			// Methods
			internal int _Send_b__14_0(string error, Dictionary<string, string> responseHeaders);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0<T1, T2>
			where T2 : class
		{
			// Fields
			public TaskCompletionSource<T2> promise;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _SendAsync_b__0(T2 x);
		}
	
		[CompilerGenerated]
		private sealed class _DelayOneSec_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action next;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayOneSec_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__23_0;
			public static Action __9__26_2;
			public static Action __9__26_0;
			public static Action __9__26_4;
			public static Action __9__26_3;
			public static Action __9__26_1;
			public static Action __9__29_0;
			public static Action __9__29_1;
			public static Action __9__29_2;
			public static Action __9__29_3;
			public static Action __9__29_4;
			public static Action __9__29_5;
			public static Action __9__29_6;
			public static Action<CharaGetListResponse> __9__29_13;
			public static Action __9__29_7;
			public static Action<CharaGetListResponse> __9__29_14;
			public static Action __9__29_8;
			public static Action __9__29_9;
			public static Action __9__29_15;
			public static Action __9__29_10;
			public static Action __9__29_16;
			public static Action __9__29_11;
			public static Action __9__29_12;
			public static Action __9__31_1;
			public static Action __9__31_3;
			public static Action __9__32_0;
			public static Action __9__33_0;
			public static Action __9__34_0;
			public static Action __9__37_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _BackToParty_b__23_0();
			internal void _GoToLoginBonus_b__26_0();
			internal void _GoToLoginBonus_b__26_2();
			internal void _GoToLoginBonus_b__26_1();
			internal void _GoToLoginBonus_b__26_3();
			internal void _GoToLoginBonus_b__26_4();
			internal void _GetAction_b__29_0();
			internal void _GetAction_b__29_1();
			internal void _GetAction_b__29_2();
			internal void _GetAction_b__29_3();
			internal void _GetAction_b__29_4();
			internal void _GetAction_b__29_5();
			internal void _GetAction_b__29_6();
			internal void _GetAction_b__29_7();
			internal void _GetAction_b__29_13(CharaGetListResponse res);
			internal void _GetAction_b__29_8();
			internal void _GetAction_b__29_14(CharaGetListResponse res);
			internal void _GetAction_b__29_9();
			internal void _GetAction_b__29_10();
			internal void _GetAction_b__29_15();
			internal void _GetAction_b__29_11();
			internal void _GetAction_b__29_16();
			internal void _GetAction_b__29_12();
			internal void _OnError_b__31_1();
			internal void _OnError_b__31_3();
			internal void _NpfBaaSAuthCallback_b__32_0();
			internal void _NpfBaaSReauthCallback_b__33_0();
			internal void _ApplicationVersionError_b__34_0();
			internal void _ReAuth_b__37_2();
			internal IHttpTask _.cctor_b__55_0(AbilityCrestBuildupPieceRequest res, Action<AbilityCrestBuildupPieceResponse> os, Action<ErrorType, int, AbilityCrestBuildupPieceResponse> oe);
			internal IHttpTask _.cctor_b__55_1(AbilityCrestBuildupPlusCountRequest res, Action<AbilityCrestBuildupPlusCountResponse> os, Action<ErrorType, int, AbilityCrestBuildupPlusCountResponse> oe);
			internal IHttpTask _.cctor_b__55_2(AbilityCrestGetAbilityCrestSetListRequest res, Action<AbilityCrestGetAbilityCrestSetListResponse> os, Action<ErrorType, int, AbilityCrestGetAbilityCrestSetListResponse> oe);
			internal IHttpTask _.cctor_b__55_3(AbilityCrestResetPlusCountRequest res, Action<AbilityCrestResetPlusCountResponse> os, Action<ErrorType, int, AbilityCrestResetPlusCountResponse> oe);
			internal IHttpTask _.cctor_b__55_4(AbilityCrestSetAbilityCrestSetRequest res, Action<AbilityCrestSetAbilityCrestSetResponse> os, Action<ErrorType, int, AbilityCrestSetAbilityCrestSetResponse> oe);
			internal IHttpTask _.cctor_b__55_5(AbilityCrestTradeGetListRequest res, Action<AbilityCrestTradeGetListResponse> os, Action<ErrorType, int, AbilityCrestTradeGetListResponse> oe);
			internal IHttpTask _.cctor_b__55_6(AbilityCrestTradeTradeRequest res, Action<AbilityCrestTradeTradeResponse> os, Action<ErrorType, int, AbilityCrestTradeTradeResponse> oe);
			internal IHttpTask _.cctor_b__55_7(AbilityCrestUpdateAbilityCrestSetNameRequest res, Action<AbilityCrestUpdateAbilityCrestSetNameResponse> os, Action<ErrorType, int, AbilityCrestUpdateAbilityCrestSetNameResponse> oe);
			internal IHttpTask _.cctor_b__55_8(AmuletBuildupRequest res, Action<AmuletBuildupResponse> os, Action<ErrorType, int, AmuletBuildupResponse> oe);
			internal IHttpTask _.cctor_b__55_9(AmuletLimitBreakRequest res, Action<AmuletLimitBreakResponse> os, Action<ErrorType, int, AmuletLimitBreakResponse> oe);
			internal IHttpTask _.cctor_b__55_10(AmuletResetPlusCountRequest res, Action<AmuletResetPlusCountResponse> os, Action<ErrorType, int, AmuletResetPlusCountResponse> oe);
			internal IHttpTask _.cctor_b__55_11(AmuletSellRequest res, Action<AmuletSellResponse> os, Action<ErrorType, int, AmuletSellResponse> oe);
			internal IHttpTask _.cctor_b__55_12(AmuletSetLockRequest res, Action<AmuletSetLockResponse> os, Action<ErrorType, int, AmuletSetLockResponse> oe);
			internal IHttpTask _.cctor_b__55_13(AmuletTradeGetListRequest res, Action<AmuletTradeGetListResponse> os, Action<ErrorType, int, AmuletTradeGetListResponse> oe);
			internal IHttpTask _.cctor_b__55_14(AmuletTradeTradeRequest res, Action<AmuletTradeTradeResponse> os, Action<ErrorType, int, AmuletTradeTradeResponse> oe);
			internal IHttpTask _.cctor_b__55_15(BattleRoyalEventEntryRequest res, Action<BattleRoyalEventEntryResponse> os, Action<ErrorType, int, BattleRoyalEventEntryResponse> oe);
			internal IHttpTask _.cctor_b__55_16(BattleRoyalEventGetEventDataRequest res, Action<BattleRoyalEventGetEventDataResponse> os, Action<ErrorType, int, BattleRoyalEventGetEventDataResponse> oe);
			internal IHttpTask _.cctor_b__55_17(BattleRoyalEventReceiveEventCyclePointRewardRequest res, Action<BattleRoyalEventReceiveEventCyclePointRewardResponse> os, Action<ErrorType, int, BattleRoyalEventReceiveEventCyclePointRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_18(BattleRoyalEventReleaseCharaSkinRequest res, Action<BattleRoyalEventReleaseCharaSkinResponse> os, Action<ErrorType, int, BattleRoyalEventReleaseCharaSkinResponse> oe);
			internal IHttpTask _.cctor_b__55_19(BattleRoyalFailRequest res, Action<BattleRoyalFailResponse> os, Action<ErrorType, int, BattleRoyalFailResponse> oe);
			internal IHttpTask _.cctor_b__55_20(BattleRoyalGetBattleRoyalHistoryRequest res, Action<BattleRoyalGetBattleRoyalHistoryResponse> os, Action<ErrorType, int, BattleRoyalGetBattleRoyalHistoryResponse> oe);
			internal IHttpTask _.cctor_b__55_21(BattleRoyalRecordRoyalRecordMultiRequest res, Action<BattleRoyalRecordRoyalRecordMultiResponse> os, Action<ErrorType, int, BattleRoyalRecordRoyalRecordMultiResponse> oe);
			internal IHttpTask _.cctor_b__55_22(BattleRoyalStartMultiRequest res, Action<BattleRoyalStartMultiResponse> os, Action<ErrorType, int, BattleRoyalStartMultiResponse> oe);
			internal IHttpTask _.cctor_b__55_23(BattleRoyalStartRoyalMultiRequest res, Action<BattleRoyalStartRoyalMultiResponse> os, Action<ErrorType, int, BattleRoyalStartRoyalMultiResponse> oe);
			internal IHttpTask _.cctor_b__55_24(BuildEventEntryRequest res, Action<BuildEventEntryResponse> os, Action<ErrorType, int, BuildEventEntryResponse> oe);
			internal IHttpTask _.cctor_b__55_25(BuildEventGetEventDataRequest res, Action<BuildEventGetEventDataResponse> os, Action<ErrorType, int, BuildEventGetEventDataResponse> oe);
			internal IHttpTask _.cctor_b__55_26(BuildEventReceiveBuildPointRewardRequest res, Action<BuildEventReceiveBuildPointRewardResponse> os, Action<ErrorType, int, BuildEventReceiveBuildPointRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_27(BuildEventReceiveDailyBonusRequest res, Action<BuildEventReceiveDailyBonusResponse> os, Action<ErrorType, int, BuildEventReceiveDailyBonusResponse> oe);
			internal IHttpTask _.cctor_b__55_28(CartoonLatestRequest res, Action<CartoonLatestResponse> os, Action<ErrorType, int, CartoonLatestResponse> oe);
			internal IHttpTask _.cctor_b__55_29(CastleStoryReadRequest res, Action<CastleStoryReadResponse> os, Action<ErrorType, int, CastleStoryReadResponse> oe);
			internal IHttpTask _.cctor_b__55_30(CharaAwakeRequest res, Action<CharaAwakeResponse> os, Action<ErrorType, int, CharaAwakeResponse> oe);
			internal IHttpTask _.cctor_b__55_31(CharaBuildupRequest res, Action<CharaBuildupResponse> os, Action<ErrorType, int, CharaBuildupResponse> oe);
			internal IHttpTask _.cctor_b__55_32(CharaBuildupManaRequest res, Action<CharaBuildupManaResponse> os, Action<ErrorType, int, CharaBuildupManaResponse> oe);
			internal IHttpTask _.cctor_b__55_33(CharaGetListRequest res, Action<CharaGetListResponse> os, Action<ErrorType, int, CharaGetListResponse> oe);
			internal IHttpTask _.cctor_b__55_34(CharaLimitBreakRequest res, Action<CharaLimitBreakResponse> os, Action<ErrorType, int, CharaLimitBreakResponse> oe);
			internal IHttpTask _.cctor_b__55_35(CharaResetPlusCountRequest res, Action<CharaResetPlusCountResponse> os, Action<ErrorType, int, CharaResetPlusCountResponse> oe);
			internal IHttpTask _.cctor_b__55_36(CharaUnlockEditSkillRequest res, Action<CharaUnlockEditSkillResponse> os, Action<ErrorType, int, CharaUnlockEditSkillResponse> oe);
			internal IHttpTask _.cctor_b__55_37(Clb01EventEntryRequest res, Action<Clb01EventEntryResponse> os, Action<ErrorType, int, Clb01EventEntryResponse> oe);
			internal IHttpTask _.cctor_b__55_38(Clb01EventGetEventDataRequest res, Action<Clb01EventGetEventDataResponse> os, Action<ErrorType, int, Clb01EventGetEventDataResponse> oe);
			internal IHttpTask _.cctor_b__55_39(Clb01EventReceiveClb01PointRewardRequest res, Action<Clb01EventReceiveClb01PointRewardResponse> os, Action<ErrorType, int, Clb01EventReceiveClb01PointRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_40(CollectEventEntryRequest res, Action<CollectEventEntryResponse> os, Action<ErrorType, int, CollectEventEntryResponse> oe);
			internal IHttpTask _.cctor_b__55_41(CollectEventGetEventDataRequest res, Action<CollectEventGetEventDataResponse> os, Action<ErrorType, int, CollectEventGetEventDataResponse> oe);
			internal IHttpTask _.cctor_b__55_42(CombatEventEntryRequest res, Action<CombatEventEntryResponse> os, Action<ErrorType, int, CombatEventEntryResponse> oe);
			internal IHttpTask _.cctor_b__55_43(CombatEventGetEventDataRequest res, Action<CombatEventGetEventDataResponse> os, Action<ErrorType, int, CombatEventGetEventDataResponse> oe);
			internal IHttpTask _.cctor_b__55_44(CombatEventReceiveEventLocationRewardRequest res, Action<CombatEventReceiveEventLocationRewardResponse> os, Action<ErrorType, int, CombatEventReceiveEventLocationRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_45(CombatEventReceiveEventPointRewardRequest res, Action<CombatEventReceiveEventPointRewardResponse> os, Action<ErrorType, int, CombatEventReceiveEventPointRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_46(CraftAssembleRequest res, Action<CraftAssembleResponse> os, Action<ErrorType, int, CraftAssembleResponse> oe);
			internal IHttpTask _.cctor_b__55_47(CraftCreateRequest res, Action<CraftCreateResponse> os, Action<ErrorType, int, CraftCreateResponse> oe);
			internal IHttpTask _.cctor_b__55_48(CraftDisassembleRequest res, Action<CraftDisassembleResponse> os, Action<ErrorType, int, CraftDisassembleResponse> oe);
			internal IHttpTask _.cctor_b__55_49(CraftResetNewRequest res, Action<CraftResetNewResponse> os, Action<ErrorType, int, CraftResetNewResponse> oe);
			internal IHttpTask _.cctor_b__55_50(DragonBuildupRequest res, Action<DragonBuildupResponse> os, Action<ErrorType, int, DragonBuildupResponse> oe);
			internal IHttpTask _.cctor_b__55_51(DragonBuyGiftToSendRequest res, Action<DragonBuyGiftToSendResponse> os, Action<ErrorType, int, DragonBuyGiftToSendResponse> oe);
			internal IHttpTask _.cctor_b__55_52(DragonBuyGiftToSendMultipleRequest res, Action<DragonBuyGiftToSendMultipleResponse> os, Action<ErrorType, int, DragonBuyGiftToSendMultipleResponse> oe);
			internal IHttpTask _.cctor_b__55_53(DragonGetContactDataRequest res, Action<DragonGetContactDataResponse> os, Action<ErrorType, int, DragonGetContactDataResponse> oe);
			internal IHttpTask _.cctor_b__55_54(DragonLimitBreakRequest res, Action<DragonLimitBreakResponse> os, Action<ErrorType, int, DragonLimitBreakResponse> oe);
			internal IHttpTask _.cctor_b__55_55(DragonResetPlusCountRequest res, Action<DragonResetPlusCountResponse> os, Action<ErrorType, int, DragonResetPlusCountResponse> oe);
			internal IHttpTask _.cctor_b__55_56(DragonSellRequest res, Action<DragonSellResponse> os, Action<ErrorType, int, DragonSellResponse> oe);
			internal IHttpTask _.cctor_b__55_57(DragonSendGiftRequest res, Action<DragonSendGiftResponse> os, Action<ErrorType, int, DragonSendGiftResponse> oe);
			internal IHttpTask _.cctor_b__55_58(DragonSendGiftMultipleRequest res, Action<DragonSendGiftMultipleResponse> os, Action<ErrorType, int, DragonSendGiftMultipleResponse> oe);
			internal IHttpTask _.cctor_b__55_59(DragonSetLockRequest res, Action<DragonSetLockResponse> os, Action<ErrorType, int, DragonSetLockResponse> oe);
			internal IHttpTask _.cctor_b__55_60(DreamAdventureClearRequest res, Action<DreamAdventureClearResponse> os, Action<ErrorType, int, DreamAdventureClearResponse> oe);
			internal IHttpTask _.cctor_b__55_61(DreamAdventurePlayRequest res, Action<DreamAdventurePlayResponse> os, Action<ErrorType, int, DreamAdventurePlayResponse> oe);
			internal IHttpTask _.cctor_b__55_62(DungeonFailRequest res, Action<DungeonFailResponse> os, Action<ErrorType, int, DungeonFailResponse> oe);
			internal IHttpTask _.cctor_b__55_63(DungeonGetAreaOddsRequest res, Action<DungeonGetAreaOddsResponse> os, Action<ErrorType, int, DungeonGetAreaOddsResponse> oe);
			internal IHttpTask _.cctor_b__55_64(DungeonReceiveQuestBonusRequest res, Action<DungeonReceiveQuestBonusResponse> os, Action<ErrorType, int, DungeonReceiveQuestBonusResponse> oe);
			internal IHttpTask _.cctor_b__55_65(DungeonRecordRecordRequest res, Action<DungeonRecordRecordResponse> os, Action<ErrorType, int, DungeonRecordRecordResponse> oe);
			internal IHttpTask _.cctor_b__55_66(DungeonRecordRecordMultiRequest res, Action<DungeonRecordRecordMultiResponse> os, Action<ErrorType, int, DungeonRecordRecordMultiResponse> oe);
			internal IHttpTask _.cctor_b__55_67(DungeonRetryRequest res, Action<DungeonRetryResponse> os, Action<ErrorType, int, DungeonRetryResponse> oe);
			internal IHttpTask _.cctor_b__55_68(DungeonSkipStartRequest res, Action<DungeonSkipStartResponse> os, Action<ErrorType, int, DungeonSkipStartResponse> oe);
			internal IHttpTask _.cctor_b__55_69(DungeonSkipStartAssignUnitRequest res, Action<DungeonSkipStartAssignUnitResponse> os, Action<ErrorType, int, DungeonSkipStartAssignUnitResponse> oe);
			internal IHttpTask _.cctor_b__55_70(DungeonStartStartRequest res, Action<DungeonStartStartResponse> os, Action<ErrorType, int, DungeonStartStartResponse> oe);
			internal IHttpTask _.cctor_b__55_71(DungeonStartStartAssignUnitRequest res, Action<DungeonStartStartAssignUnitResponse> os, Action<ErrorType, int, DungeonStartStartAssignUnitResponse> oe);
			internal IHttpTask _.cctor_b__55_72(DungeonStartStartMultiRequest res, Action<DungeonStartStartMultiResponse> os, Action<ErrorType, int, DungeonStartStartMultiResponse> oe);
			internal IHttpTask _.cctor_b__55_73(DungeonStartStartMultiAssignUnitRequest res, Action<DungeonStartStartMultiAssignUnitResponse> os, Action<ErrorType, int, DungeonStartStartMultiAssignUnitResponse> oe);
			internal IHttpTask _.cctor_b__55_74(EmblemGetListRequest res, Action<EmblemGetListResponse> os, Action<ErrorType, int, EmblemGetListResponse> oe);
			internal IHttpTask _.cctor_b__55_75(EmblemSetRequest res, Action<EmblemSetResponse> os, Action<ErrorType, int, EmblemSetResponse> oe);
			internal IHttpTask _.cctor_b__55_76(EulaAgreeAgreeRequest res, Action<EulaAgreeAgreeResponse> os, Action<ErrorType, int, EulaAgreeAgreeResponse> oe);
			internal IHttpTask _.cctor_b__55_77(EulaGetVersionRequest res, Action<EulaGetVersionResponse> os, Action<ErrorType, int, EulaGetVersionResponse> oe);
			internal IHttpTask _.cctor_b__55_78(EulaGetVersionListRequest res, Action<EulaGetVersionListResponse> os, Action<ErrorType, int, EulaGetVersionListResponse> oe);
			internal IHttpTask _.cctor_b__55_79(EventStoryReadRequest res, Action<EventStoryReadResponse> os, Action<ErrorType, int, EventStoryReadResponse> oe);
			internal IHttpTask _.cctor_b__55_80(EventSummonExecRequest res, Action<EventSummonExecResponse> os, Action<ErrorType, int, EventSummonExecResponse> oe);
			internal IHttpTask _.cctor_b__55_81(EventSummonGetDataRequest res, Action<EventSummonGetDataResponse> os, Action<ErrorType, int, EventSummonGetDataResponse> oe);
			internal IHttpTask _.cctor_b__55_82(EventSummonResetRequest res, Action<EventSummonResetResponse> os, Action<ErrorType, int, EventSummonResetResponse> oe);
			internal IHttpTask _.cctor_b__55_83(EventTradeGetListRequest res, Action<EventTradeGetListResponse> os, Action<ErrorType, int, EventTradeGetListResponse> oe);
			internal IHttpTask _.cctor_b__55_84(EventTradeTradeRequest res, Action<EventTradeTradeResponse> os, Action<ErrorType, int, EventTradeTradeResponse> oe);
			internal IHttpTask _.cctor_b__55_85(ExHunterEventEntryRequest res, Action<ExHunterEventEntryResponse> os, Action<ErrorType, int, ExHunterEventEntryResponse> oe);
			internal IHttpTask _.cctor_b__55_86(ExHunterEventGetEventDataRequest res, Action<ExHunterEventGetEventDataResponse> os, Action<ErrorType, int, ExHunterEventGetEventDataResponse> oe);
			internal IHttpTask _.cctor_b__55_87(ExHunterEventReceiveExHunterPointRewardRequest res, Action<ExHunterEventReceiveExHunterPointRewardResponse> os, Action<ErrorType, int, ExHunterEventReceiveExHunterPointRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_88(ExRushEventEntryRequest res, Action<ExRushEventEntryResponse> os, Action<ErrorType, int, ExRushEventEntryResponse> oe);
			internal IHttpTask _.cctor_b__55_89(ExRushEventGetEventDataRequest res, Action<ExRushEventGetEventDataResponse> os, Action<ErrorType, int, ExRushEventGetEventDataResponse> oe);
			internal IHttpTask _.cctor_b__55_90(FortAddCarpenterRequest res, Action<FortAddCarpenterResponse> os, Action<ErrorType, int, FortAddCarpenterResponse> oe);
			internal IHttpTask _.cctor_b__55_91(FortBuildAtOnceRequest res, Action<FortBuildAtOnceResponse> os, Action<ErrorType, int, FortBuildAtOnceResponse> oe);
			internal IHttpTask _.cctor_b__55_92(FortBuildCancelRequest res, Action<FortBuildCancelResponse> os, Action<ErrorType, int, FortBuildCancelResponse> oe);
			internal IHttpTask _.cctor_b__55_93(FortBuildEndRequest res, Action<FortBuildEndResponse> os, Action<ErrorType, int, FortBuildEndResponse> oe);
			internal IHttpTask _.cctor_b__55_94(FortBuildStartRequest res, Action<FortBuildStartResponse> os, Action<ErrorType, int, FortBuildStartResponse> oe);
			internal IHttpTask _.cctor_b__55_95(FortGetDataRequest res, Action<FortGetDataResponse> os, Action<ErrorType, int, FortGetDataResponse> oe);
			internal IHttpTask _.cctor_b__55_96(FortGetMultiIncomeRequest res, Action<FortGetMultiIncomeResponse> os, Action<ErrorType, int, FortGetMultiIncomeResponse> oe);
			internal IHttpTask _.cctor_b__55_97(FortLevelupAtOnceRequest res, Action<FortLevelupAtOnceResponse> os, Action<ErrorType, int, FortLevelupAtOnceResponse> oe);
			internal IHttpTask _.cctor_b__55_98(FortLevelupCancelRequest res, Action<FortLevelupCancelResponse> os, Action<ErrorType, int, FortLevelupCancelResponse> oe);
			internal IHttpTask _.cctor_b__55_99(FortLevelupEndRequest res, Action<FortLevelupEndResponse> os, Action<ErrorType, int, FortLevelupEndResponse> oe);
			internal IHttpTask _.cctor_b__55_100(FortLevelupStartRequest res, Action<FortLevelupStartResponse> os, Action<ErrorType, int, FortLevelupStartResponse> oe);
			internal IHttpTask _.cctor_b__55_101(FortMoveRequest res, Action<FortMoveResponse> os, Action<ErrorType, int, FortMoveResponse> oe);
			internal IHttpTask _.cctor_b__55_102(FortSetNewFortPlantRequest res, Action<FortSetNewFortPlantResponse> os, Action<ErrorType, int, FortSetNewFortPlantResponse> oe);
			internal IHttpTask _.cctor_b__55_103(FriendAllReplyDenyRequest res, Action<FriendAllReplyDenyResponse> os, Action<ErrorType, int, FriendAllReplyDenyResponse> oe);
			internal IHttpTask _.cctor_b__55_104(FriendApplyListRequest res, Action<FriendApplyListResponse> os, Action<ErrorType, int, FriendApplyListResponse> oe);
			internal IHttpTask _.cctor_b__55_105(FriendAutoSearchRequest res, Action<FriendAutoSearchResponse> os, Action<ErrorType, int, FriendAutoSearchResponse> oe);
			internal IHttpTask _.cctor_b__55_106(FriendDeleteRequest res, Action<FriendDeleteResponse> os, Action<ErrorType, int, FriendDeleteResponse> oe);
			internal IHttpTask _.cctor_b__55_107(FriendFriendIndexRequest res, Action<FriendFriendIndexResponse> os, Action<ErrorType, int, FriendFriendIndexResponse> oe);
			internal IHttpTask _.cctor_b__55_108(FriendFriendListRequest res, Action<FriendFriendListResponse> os, Action<ErrorType, int, FriendFriendListResponse> oe);
			internal IHttpTask _.cctor_b__55_109(FriendGetSupportCharaRequest res, Action<FriendGetSupportCharaResponse> os, Action<ErrorType, int, FriendGetSupportCharaResponse> oe);
			internal IHttpTask _.cctor_b__55_110(FriendGetSupportCharaDetailRequest res, Action<FriendGetSupportCharaDetailResponse> os, Action<ErrorType, int, FriendGetSupportCharaDetailResponse> oe);
			internal IHttpTask _.cctor_b__55_111(FriendIdSearchRequest res, Action<FriendIdSearchResponse> os, Action<ErrorType, int, FriendIdSearchResponse> oe);
			internal IHttpTask _.cctor_b__55_112(FriendReplyRequest res, Action<FriendReplyResponse> os, Action<ErrorType, int, FriendReplyResponse> oe);
			internal IHttpTask _.cctor_b__55_113(FriendRequestRequest res, Action<FriendRequestResponse> os, Action<ErrorType, int, FriendRequestResponse> oe);
			internal IHttpTask _.cctor_b__55_114(FriendRequestCancelRequest res, Action<FriendRequestCancelResponse> os, Action<ErrorType, int, FriendRequestCancelResponse> oe);
			internal IHttpTask _.cctor_b__55_115(FriendRequestListRequest res, Action<FriendRequestListResponse> os, Action<ErrorType, int, FriendRequestListResponse> oe);
			internal IHttpTask _.cctor_b__55_116(FriendSetSupportCharaRequest res, Action<FriendSetSupportCharaResponse> os, Action<ErrorType, int, FriendSetSupportCharaResponse> oe);
			internal IHttpTask _.cctor_b__55_117(GuildChatGetNewMessageListRequest res, Action<GuildChatGetNewMessageListResponse> os, Action<ErrorType, int, GuildChatGetNewMessageListResponse> oe);
			internal IHttpTask _.cctor_b__55_118(GuildChatGetOldMessageListRequest res, Action<GuildChatGetOldMessageListResponse> os, Action<ErrorType, int, GuildChatGetOldMessageListResponse> oe);
			internal IHttpTask _.cctor_b__55_119(GuildChatPostMessageStampRequest res, Action<GuildChatPostMessageStampResponse> os, Action<ErrorType, int, GuildChatPostMessageStampResponse> oe);
			internal IHttpTask _.cctor_b__55_120(GuildChatPostMessageTextRequest res, Action<GuildChatPostMessageTextResponse> os, Action<ErrorType, int, GuildChatPostMessageTextResponse> oe);
			internal IHttpTask _.cctor_b__55_121(GuildChatPostReportRequest res, Action<GuildChatPostReportResponse> os, Action<ErrorType, int, GuildChatPostReportResponse> oe);
			internal IHttpTask _.cctor_b__55_122(GuildDisbandRequest res, Action<GuildDisbandResponse> os, Action<ErrorType, int, GuildDisbandResponse> oe);
			internal IHttpTask _.cctor_b__55_123(GuildDropMemberRequest res, Action<GuildDropMemberResponse> os, Action<ErrorType, int, GuildDropMemberResponse> oe);
			internal IHttpTask _.cctor_b__55_124(GuildEstablishRequest res, Action<GuildEstablishResponse> os, Action<ErrorType, int, GuildEstablishResponse> oe);
			internal IHttpTask _.cctor_b__55_125(GuildGetGuildApplyDataRequest res, Action<GuildGetGuildApplyDataResponse> os, Action<ErrorType, int, GuildGetGuildApplyDataResponse> oe);
			internal IHttpTask _.cctor_b__55_126(GuildGetGuildMemberDataRequest res, Action<GuildGetGuildMemberDataResponse> os, Action<ErrorType, int, GuildGetGuildMemberDataResponse> oe);
			internal IHttpTask _.cctor_b__55_127(GuildIndexRequest res, Action<GuildIndexResponse> os, Action<ErrorType, int, GuildIndexResponse> oe);
			internal IHttpTask _.cctor_b__55_128(GuildInviteGetGuildInviteReceiveDataRequest res, Action<GuildInviteGetGuildInviteReceiveDataResponse> os, Action<ErrorType, int, GuildInviteGetGuildInviteReceiveDataResponse> oe);
			internal IHttpTask _.cctor_b__55_129(GuildInviteGetGuildInviteSendDataRequest res, Action<GuildInviteGetGuildInviteSendDataResponse> os, Action<ErrorType, int, GuildInviteGetGuildInviteSendDataResponse> oe);
			internal IHttpTask _.cctor_b__55_130(GuildInviteInviteCancelRequest res, Action<GuildInviteInviteCancelResponse> os, Action<ErrorType, int, GuildInviteInviteCancelResponse> oe);
			internal IHttpTask _.cctor_b__55_131(GuildInviteInviteReplyRequest res, Action<GuildInviteInviteReplyResponse> os, Action<ErrorType, int, GuildInviteInviteReplyResponse> oe);
			internal IHttpTask _.cctor_b__55_132(GuildInviteInviteReplyAllDenyRequest res, Action<GuildInviteInviteReplyAllDenyResponse> os, Action<ErrorType, int, GuildInviteInviteReplyAllDenyResponse> oe);
			internal IHttpTask _.cctor_b__55_133(GuildInviteInviteSendRequest res, Action<GuildInviteInviteSendResponse> os, Action<ErrorType, int, GuildInviteInviteSendResponse> oe);
			internal IHttpTask _.cctor_b__55_134(GuildJoinRequest res, Action<GuildJoinResponse> os, Action<ErrorType, int, GuildJoinResponse> oe);
			internal IHttpTask _.cctor_b__55_135(GuildJoinReplyRequest res, Action<GuildJoinReplyResponse> os, Action<ErrorType, int, GuildJoinReplyResponse> oe);
			internal IHttpTask _.cctor_b__55_136(GuildJoinReplyAllDenyRequest res, Action<GuildJoinReplyAllDenyResponse> os, Action<ErrorType, int, GuildJoinReplyAllDenyResponse> oe);
			internal IHttpTask _.cctor_b__55_137(GuildJoinRequestRequest res, Action<GuildJoinRequestResponse> os, Action<ErrorType, int, GuildJoinRequestResponse> oe);
			internal IHttpTask _.cctor_b__55_138(GuildJoinRequestCancelRequest res, Action<GuildJoinRequestCancelResponse> os, Action<ErrorType, int, GuildJoinRequestCancelResponse> oe);
			internal IHttpTask _.cctor_b__55_139(GuildPostReportRequest res, Action<GuildPostReportResponse> os, Action<ErrorType, int, GuildPostReportResponse> oe);
			internal IHttpTask _.cctor_b__55_140(GuildResignRequest res, Action<GuildResignResponse> os, Action<ErrorType, int, GuildResignResponse> oe);
			internal IHttpTask _.cctor_b__55_141(GuildSearchAutoSearchRequest res, Action<GuildSearchAutoSearchResponse> os, Action<ErrorType, int, GuildSearchAutoSearchResponse> oe);
			internal IHttpTask _.cctor_b__55_142(GuildSearchGetGuildDetailRequest res, Action<GuildSearchGetGuildDetailResponse> os, Action<ErrorType, int, GuildSearchGetGuildDetailResponse> oe);
			internal IHttpTask _.cctor_b__55_143(GuildSearchIdSearchRequest res, Action<GuildSearchIdSearchResponse> os, Action<ErrorType, int, GuildSearchIdSearchResponse> oe);
			internal IHttpTask _.cctor_b__55_144(GuildSearchNameSearchRequest res, Action<GuildSearchNameSearchResponse> os, Action<ErrorType, int, GuildSearchNameSearchResponse> oe);
			internal IHttpTask _.cctor_b__55_145(GuildUpdateGuildPositionTypeRequest res, Action<GuildUpdateGuildPositionTypeResponse> os, Action<ErrorType, int, GuildUpdateGuildPositionTypeResponse> oe);
			internal IHttpTask _.cctor_b__55_146(GuildUpdateGuildSettingRequest res, Action<GuildUpdateGuildSettingResponse> os, Action<ErrorType, int, GuildUpdateGuildSettingResponse> oe);
			internal IHttpTask _.cctor_b__55_147(GuildUpdateUserSettingRequest res, Action<GuildUpdateUserSettingResponse> os, Action<ErrorType, int, GuildUpdateUserSettingResponse> oe);
			internal IHttpTask _.cctor_b__55_148(InquiryAggregationRequest res, Action<InquiryAggregationResponse> os, Action<ErrorType, int, InquiryAggregationResponse> oe);
			internal IHttpTask _.cctor_b__55_149(InquiryDetailRequest res, Action<InquiryDetailResponse> os, Action<ErrorType, int, InquiryDetailResponse> oe);
			internal IHttpTask _.cctor_b__55_150(InquiryReplyRequest res, Action<InquiryReplyResponse> os, Action<ErrorType, int, InquiryReplyResponse> oe);
			internal IHttpTask _.cctor_b__55_151(InquirySendRequest res, Action<InquirySendResponse> os, Action<ErrorType, int, InquirySendResponse> oe);
			internal IHttpTask _.cctor_b__55_152(InquiryTopRequest res, Action<InquiryTopResponse> os, Action<ErrorType, int, InquiryTopResponse> oe);
			internal IHttpTask _.cctor_b__55_153(ItemGetListRequest res, Action<ItemGetListResponse> os, Action<ErrorType, int, ItemGetListResponse> oe);
			internal IHttpTask _.cctor_b__55_154(ItemUseRecoveryStaminaRequest res, Action<ItemUseRecoveryStaminaResponse> os, Action<ErrorType, int, ItemUseRecoveryStaminaResponse> oe);
			internal IHttpTask _.cctor_b__55_155(LoadIndexRequest res, Action<LoadIndexResponse> os, Action<ErrorType, int, LoadIndexResponse> oe);
			internal IHttpTask _.cctor_b__55_156(LoginIndexRequest res, Action<LoginIndexResponse> os, Action<ErrorType, int, LoginIndexResponse> oe);
			internal IHttpTask _.cctor_b__55_157(LoginPenaltyConfirmRequest res, Action<LoginPenaltyConfirmResponse> os, Action<ErrorType, int, LoginPenaltyConfirmResponse> oe);
			internal IHttpTask _.cctor_b__55_158(LoginVerifyJwsRequest res, Action<LoginVerifyJwsResponse> os, Action<ErrorType, int, LoginVerifyJwsResponse> oe);
			internal IHttpTask _.cctor_b__55_159(LotteryGetOddsDataRequest res, Action<LotteryGetOddsDataResponse> os, Action<ErrorType, int, LotteryGetOddsDataResponse> oe);
			internal IHttpTask _.cctor_b__55_160(LotteryLotteryExecRequest res, Action<LotteryLotteryExecResponse> os, Action<ErrorType, int, LotteryLotteryExecResponse> oe);
			internal IHttpTask _.cctor_b__55_161(LotteryResultRequest res, Action<LotteryResultResponse> os, Action<ErrorType, int, LotteryResultResponse> oe);
			internal IHttpTask _.cctor_b__55_162(MaintenanceGetTextRequest res, Action<MaintenanceGetTextResponse> os, Action<ErrorType, int, MaintenanceGetTextResponse> oe);
			internal IHttpTask _.cctor_b__55_163(MatchingCheckPenaltyUserRequest res, Action<MatchingCheckPenaltyUserResponse> os, Action<ErrorType, int, MatchingCheckPenaltyUserResponse> oe);
			internal IHttpTask _.cctor_b__55_164(MatchingGetRoomListRequest res, Action<MatchingGetRoomListResponse> os, Action<ErrorType, int, MatchingGetRoomListResponse> oe);
			internal IHttpTask _.cctor_b__55_165(MatchingGetRoomListByGuildRequest res, Action<MatchingGetRoomListByGuildResponse> os, Action<ErrorType, int, MatchingGetRoomListByGuildResponse> oe);
			internal IHttpTask _.cctor_b__55_166(MatchingGetRoomListByLocationRequest res, Action<MatchingGetRoomListByLocationResponse> os, Action<ErrorType, int, MatchingGetRoomListByLocationResponse> oe);
			internal IHttpTask _.cctor_b__55_167(MatchingGetRoomListByQuestIdRequest res, Action<MatchingGetRoomListByQuestIdResponse> os, Action<ErrorType, int, MatchingGetRoomListByQuestIdResponse> oe);
			internal IHttpTask _.cctor_b__55_168(MatchingGetRoomNameRequest res, Action<MatchingGetRoomNameResponse> os, Action<ErrorType, int, MatchingGetRoomNameResponse> oe);
			internal IHttpTask _.cctor_b__55_169(MazeEventEntryRequest res, Action<MazeEventEntryResponse> os, Action<ErrorType, int, MazeEventEntryResponse> oe);
			internal IHttpTask _.cctor_b__55_170(MazeEventGetEventDataRequest res, Action<MazeEventGetEventDataResponse> os, Action<ErrorType, int, MazeEventGetEventDataResponse> oe);
			internal IHttpTask _.cctor_b__55_171(MazeEventReceiveMazePointRewardRequest res, Action<MazeEventReceiveMazePointRewardResponse> os, Action<ErrorType, int, MazeEventReceiveMazePointRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_172(MemoryEventActivateRequest res, Action<MemoryEventActivateResponse> os, Action<ErrorType, int, MemoryEventActivateResponse> oe);
			internal IHttpTask _.cctor_b__55_173(MissionGetDrillMissionListRequest res, Action<MissionGetDrillMissionListResponse> os, Action<ErrorType, int, MissionGetDrillMissionListResponse> oe);
			internal IHttpTask _.cctor_b__55_174(MissionGetMissionListRequest res, Action<MissionGetMissionListResponse> os, Action<ErrorType, int, MissionGetMissionListResponse> oe);
			internal IHttpTask _.cctor_b__55_175(MissionReceiveBeginnerRewardRequest res, Action<MissionReceiveBeginnerRewardResponse> os, Action<ErrorType, int, MissionReceiveBeginnerRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_176(MissionReceiveDailyRewardRequest res, Action<MissionReceiveDailyRewardResponse> os, Action<ErrorType, int, MissionReceiveDailyRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_177(MissionReceiveDrillRewardRequest res, Action<MissionReceiveDrillRewardResponse> os, Action<ErrorType, int, MissionReceiveDrillRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_178(MissionReceiveMainStoryRewardRequest res, Action<MissionReceiveMainStoryRewardResponse> os, Action<ErrorType, int, MissionReceiveMainStoryRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_179(MissionReceiveMemoryEventRewardRequest res, Action<MissionReceiveMemoryEventRewardResponse> os, Action<ErrorType, int, MissionReceiveMemoryEventRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_180(MissionReceiveNormalRewardRequest res, Action<MissionReceiveNormalRewardResponse> os, Action<ErrorType, int, MissionReceiveNormalRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_181(MissionReceivePeriodRewardRequest res, Action<MissionReceivePeriodRewardResponse> os, Action<ErrorType, int, MissionReceivePeriodRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_182(MissionReceiveSpecialRewardRequest res, Action<MissionReceiveSpecialRewardResponse> os, Action<ErrorType, int, MissionReceiveSpecialRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_183(MissionUnlockDrillMissionGroupRequest res, Action<MissionUnlockDrillMissionGroupResponse> os, Action<ErrorType, int, MissionUnlockDrillMissionGroupResponse> oe);
			internal IHttpTask _.cctor_b__55_184(MissionUnlockMainStoryGroupRequest res, Action<MissionUnlockMainStoryGroupResponse> os, Action<ErrorType, int, MissionUnlockMainStoryGroupResponse> oe);
			internal IHttpTask _.cctor_b__55_185(MypageInfoRequest res, Action<MypageInfoResponse> os, Action<ErrorType, int, MypageInfoResponse> oe);
			internal IHttpTask _.cctor_b__55_186(OptionGetOptionRequest res, Action<OptionGetOptionResponse> os, Action<ErrorType, int, OptionGetOptionResponse> oe);
			internal IHttpTask _.cctor_b__55_187(OptionSetOptionRequest res, Action<OptionSetOptionResponse> os, Action<ErrorType, int, OptionSetOptionResponse> oe);
			internal IHttpTask _.cctor_b__55_188(PartyIndexRequest res, Action<PartyIndexResponse> os, Action<ErrorType, int, PartyIndexResponse> oe);
			internal IHttpTask _.cctor_b__55_189(PartySetMainPartyNoRequest res, Action<PartySetMainPartyNoResponse> os, Action<ErrorType, int, PartySetMainPartyNoResponse> oe);
			internal IHttpTask _.cctor_b__55_190(PartySetPartySettingRequest res, Action<PartySetPartySettingResponse> os, Action<ErrorType, int, PartySetPartySettingResponse> oe);
			internal IHttpTask _.cctor_b__55_191(PartyUpdatePartyNameRequest res, Action<PartyUpdatePartyNameResponse> os, Action<ErrorType, int, PartyUpdatePartyNameResponse> oe);
			internal IHttpTask _.cctor_b__55_192(PlatformAchievementGetPlatformAchievementListRequest res, Action<PlatformAchievementGetPlatformAchievementListResponse> os, Action<ErrorType, int, PlatformAchievementGetPlatformAchievementListResponse> oe);
			internal IHttpTask _.cctor_b__55_193(PresentGetHistoryListRequest res, Action<PresentGetHistoryListResponse> os, Action<ErrorType, int, PresentGetHistoryListResponse> oe);
			internal IHttpTask _.cctor_b__55_194(PresentGetPresentListRequest res, Action<PresentGetPresentListResponse> os, Action<ErrorType, int, PresentGetPresentListResponse> oe);
			internal IHttpTask _.cctor_b__55_195(PresentReceiveRequest res, Action<PresentReceiveResponse> os, Action<ErrorType, int, PresentReceiveResponse> oe);
			internal IHttpTask _.cctor_b__55_196(PushNotificationUpdateSettingRequest res, Action<PushNotificationUpdateSettingResponse> os, Action<ErrorType, int, PushNotificationUpdateSettingResponse> oe);
			internal IHttpTask _.cctor_b__55_197(QuestDropListRequest res, Action<QuestDropListResponse> os, Action<ErrorType, int, QuestDropListResponse> oe);
			internal IHttpTask _.cctor_b__55_198(QuestGetQuestClearPartyRequest res, Action<QuestGetQuestClearPartyResponse> os, Action<ErrorType, int, QuestGetQuestClearPartyResponse> oe);
			internal IHttpTask _.cctor_b__55_199(QuestGetQuestClearPartyMultiRequest res, Action<QuestGetQuestClearPartyMultiResponse> os, Action<ErrorType, int, QuestGetQuestClearPartyMultiResponse> oe);
			internal IHttpTask _.cctor_b__55_200(QuestGetSupportUserListRequest res, Action<QuestGetSupportUserListResponse> os, Action<ErrorType, int, QuestGetSupportUserListResponse> oe);
			internal IHttpTask _.cctor_b__55_201(QuestOpenTreasureRequest res, Action<QuestOpenTreasureResponse> os, Action<ErrorType, int, QuestOpenTreasureResponse> oe);
			internal IHttpTask _.cctor_b__55_202(QuestReadStoryRequest res, Action<QuestReadStoryResponse> os, Action<ErrorType, int, QuestReadStoryResponse> oe);
			internal IHttpTask _.cctor_b__55_203(QuestSetQuestClearPartyRequest res, Action<QuestSetQuestClearPartyResponse> os, Action<ErrorType, int, QuestSetQuestClearPartyResponse> oe);
			internal IHttpTask _.cctor_b__55_204(QuestSetQuestClearPartyMultiRequest res, Action<QuestSetQuestClearPartyMultiResponse> os, Action<ErrorType, int, QuestSetQuestClearPartyMultiResponse> oe);
			internal IHttpTask _.cctor_b__55_205(RaidEventEntryRequest res, Action<RaidEventEntryResponse> os, Action<ErrorType, int, RaidEventEntryResponse> oe);
			internal IHttpTask _.cctor_b__55_206(RaidEventGetEventDataRequest res, Action<RaidEventGetEventDataResponse> os, Action<ErrorType, int, RaidEventGetEventDataResponse> oe);
			internal IHttpTask _.cctor_b__55_207(RaidEventReceiveRaidPointRewardRequest res, Action<RaidEventReceiveRaidPointRewardResponse> os, Action<ErrorType, int, RaidEventReceiveRaidPointRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_208(RepeatEndRequest res, Action<RepeatEndResponse> os, Action<ErrorType, int, RepeatEndResponse> oe);
			internal IHttpTask _.cctor_b__55_209(ShopChargeCancelRequest res, Action<ShopChargeCancelResponse> os, Action<ErrorType, int, ShopChargeCancelResponse> oe);
			internal IHttpTask _.cctor_b__55_210(ShopGetBonusRequest res, Action<ShopGetBonusResponse> os, Action<ErrorType, int, ShopGetBonusResponse> oe);
			internal IHttpTask _.cctor_b__55_211(ShopGetDreamSelectUnitListRequest res, Action<ShopGetDreamSelectUnitListResponse> os, Action<ErrorType, int, ShopGetDreamSelectUnitListResponse> oe);
			internal IHttpTask _.cctor_b__55_212(ShopGetListRequest res, Action<ShopGetListResponse> os, Action<ErrorType, int, ShopGetListResponse> oe);
			internal IHttpTask _.cctor_b__55_213(ShopGetProductListRequest res, Action<ShopGetProductListResponse> os, Action<ErrorType, int, ShopGetProductListResponse> oe);
			internal IHttpTask _.cctor_b__55_214(ShopItemSummonExecRequest res, Action<ShopItemSummonExecResponse> os, Action<ErrorType, int, ShopItemSummonExecResponse> oe);
			internal IHttpTask _.cctor_b__55_215(ShopItemSummonOddRequest res, Action<ShopItemSummonOddResponse> os, Action<ErrorType, int, ShopItemSummonOddResponse> oe);
			internal IHttpTask _.cctor_b__55_216(ShopMaterialShopPurchaseRequest res, Action<ShopMaterialShopPurchaseResponse> os, Action<ErrorType, int, ShopMaterialShopPurchaseResponse> oe);
			internal IHttpTask _.cctor_b__55_217(ShopNormalShopPurchaseRequest res, Action<ShopNormalShopPurchaseResponse> os, Action<ErrorType, int, ShopNormalShopPurchaseResponse> oe);
			internal IHttpTask _.cctor_b__55_218(ShopPreChargeCheckRequest res, Action<ShopPreChargeCheckResponse> os, Action<ErrorType, int, ShopPreChargeCheckResponse> oe);
			internal IHttpTask _.cctor_b__55_219(ShopSpecialShopPurchaseRequest res, Action<ShopSpecialShopPurchaseResponse> os, Action<ErrorType, int, ShopSpecialShopPurchaseResponse> oe);
			internal IHttpTask _.cctor_b__55_220(SimpleEventEntryRequest res, Action<SimpleEventEntryResponse> os, Action<ErrorType, int, SimpleEventEntryResponse> oe);
			internal IHttpTask _.cctor_b__55_221(SimpleEventGetEventDataRequest res, Action<SimpleEventGetEventDataResponse> os, Action<ErrorType, int, SimpleEventGetEventDataResponse> oe);
			internal IHttpTask _.cctor_b__55_222(StampGetStampRequest res, Action<StampGetStampResponse> os, Action<ErrorType, int, StampGetStampResponse> oe);
			internal IHttpTask _.cctor_b__55_223(StampSetEquipStampRequest res, Action<StampSetEquipStampResponse> os, Action<ErrorType, int, StampSetEquipStampResponse> oe);
			internal IHttpTask _.cctor_b__55_224(StoryReadRequest res, Action<StoryReadResponse> os, Action<ErrorType, int, StoryReadResponse> oe);
			internal IHttpTask _.cctor_b__55_225(StorySkipSkipRequest res, Action<StorySkipSkipResponse> os, Action<ErrorType, int, StorySkipSkipResponse> oe);
			internal IHttpTask _.cctor_b__55_226(SuggestionGetCategoryListRequest res, Action<SuggestionGetCategoryListResponse> os, Action<ErrorType, int, SuggestionGetCategoryListResponse> oe);
			internal IHttpTask _.cctor_b__55_227(SuggestionSetRequest res, Action<SuggestionSetResponse> os, Action<ErrorType, int, SuggestionSetResponse> oe);
			internal IHttpTask _.cctor_b__55_228(SummonGetOddsDataRequest res, Action<SummonGetOddsDataResponse> os, Action<ErrorType, int, SummonGetOddsDataResponse> oe);
			internal IHttpTask _.cctor_b__55_229(SummonGetSummonHistoryRequest res, Action<SummonGetSummonHistoryResponse> os, Action<ErrorType, int, SummonGetSummonHistoryResponse> oe);
			internal IHttpTask _.cctor_b__55_230(SummonGetSummonListRequest res, Action<SummonGetSummonListResponse> os, Action<ErrorType, int, SummonGetSummonListResponse> oe);
			internal IHttpTask _.cctor_b__55_231(SummonGetSummonPointTradeRequest res, Action<SummonGetSummonPointTradeResponse> os, Action<ErrorType, int, SummonGetSummonPointTradeResponse> oe);
			internal IHttpTask _.cctor_b__55_232(SummonRequestRequest res, Action<SummonRequestResponse> os, Action<ErrorType, int, SummonRequestResponse> oe);
			internal IHttpTask _.cctor_b__55_233(SummonSummonPointTradeRequest res, Action<SummonSummonPointTradeResponse> os, Action<ErrorType, int, SummonSummonPointTradeResponse> oe);
			internal IHttpTask _.cctor_b__55_234(TimeAttackRankingGetDataRequest res, Action<TimeAttackRankingGetDataResponse> os, Action<ErrorType, int, TimeAttackRankingGetDataResponse> oe);
			internal IHttpTask _.cctor_b__55_235(TimeAttackRankingReceiveTierRewardRequest res, Action<TimeAttackRankingReceiveTierRewardResponse> os, Action<ErrorType, int, TimeAttackRankingReceiveTierRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_236(ToolAuthRequest res, Action<ToolAuthResponse> os, Action<ErrorType, int, ToolAuthResponse> oe);
			internal IHttpTask _.cctor_b__55_237(ToolGetMaintenanceTimeRequest res, Action<ToolGetMaintenanceTimeResponse> os, Action<ErrorType, int, ToolGetMaintenanceTimeResponse> oe);
			internal IHttpTask _.cctor_b__55_238(ToolReauthRequest res, Action<ToolReauthResponse> os, Action<ErrorType, int, ToolReauthResponse> oe);
			internal IHttpTask _.cctor_b__55_239(ToolSignupRequest res, Action<ToolSignupResponse> os, Action<ErrorType, int, ToolSignupResponse> oe);
			internal IHttpTask _.cctor_b__55_240(TrackRecordUpdateProgressRequest res, Action<TrackRecordUpdateProgressResponse> os, Action<ErrorType, int, TrackRecordUpdateProgressResponse> oe);
			internal IHttpTask _.cctor_b__55_241(TransitionTransitionByNAccountRequest res, Action<TransitionTransitionByNAccountResponse> os, Action<ErrorType, int, TransitionTransitionByNAccountResponse> oe);
			internal IHttpTask _.cctor_b__55_242(TreasureTradeGetListRequest res, Action<TreasureTradeGetListResponse> os, Action<ErrorType, int, TreasureTradeGetListResponse> oe);
			internal IHttpTask _.cctor_b__55_243(TreasureTradeGetListAllRequest res, Action<TreasureTradeGetListAllResponse> os, Action<ErrorType, int, TreasureTradeGetListAllResponse> oe);
			internal IHttpTask _.cctor_b__55_244(TreasureTradeTradeRequest res, Action<TreasureTradeTradeResponse> os, Action<ErrorType, int, TreasureTradeTradeResponse> oe);
			internal IHttpTask _.cctor_b__55_245(TutorialUpdateFlagsRequest res, Action<TutorialUpdateFlagsResponse> os, Action<ErrorType, int, TutorialUpdateFlagsResponse> oe);
			internal IHttpTask _.cctor_b__55_246(TutorialUpdateStepRequest res, Action<TutorialUpdateStepResponse> os, Action<ErrorType, int, TutorialUpdateStepResponse> oe);
			internal IHttpTask _.cctor_b__55_247(UpdateNamechangeRequest res, Action<UpdateNamechangeResponse> os, Action<ErrorType, int, UpdateNamechangeResponse> oe);
			internal IHttpTask _.cctor_b__55_248(UpdateResetNewRequest res, Action<UpdateResetNewResponse> os, Action<ErrorType, int, UpdateResetNewResponse> oe);
			internal IHttpTask _.cctor_b__55_249(UserLinkedNAccountRequest res, Action<UserLinkedNAccountResponse> os, Action<ErrorType, int, UserLinkedNAccountResponse> oe);
			internal IHttpTask _.cctor_b__55_250(UserOptInSettingRequest res, Action<UserOptInSettingResponse> os, Action<ErrorType, int, UserOptInSettingResponse> oe);
			internal IHttpTask _.cctor_b__55_251(UserRecoverStaminaByStoneRequest res, Action<UserRecoverStaminaByStoneResponse> os, Action<ErrorType, int, UserRecoverStaminaByStoneResponse> oe);
			internal IHttpTask _.cctor_b__55_252(UserWithdrawalRequest res, Action<UserWithdrawalResponse> os, Action<ErrorType, int, UserWithdrawalResponse> oe);
			internal IHttpTask _.cctor_b__55_253(VersionGetResourceVersionRequest res, Action<VersionGetResourceVersionResponse> os, Action<ErrorType, int, VersionGetResourceVersionResponse> oe);
			internal IHttpTask _.cctor_b__55_254(WalkerSendGiftMultipleRequest res, Action<WalkerSendGiftMultipleResponse> os, Action<ErrorType, int, WalkerSendGiftMultipleResponse> oe);
			internal IHttpTask _.cctor_b__55_255(WallFailRequest res, Action<WallFailResponse> os, Action<ErrorType, int, WallFailResponse> oe);
			internal IHttpTask _.cctor_b__55_256(WallGetMonthlyRewardRequest res, Action<WallGetMonthlyRewardResponse> os, Action<ErrorType, int, WallGetMonthlyRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_257(WallGetWallClearPartyRequest res, Action<WallGetWallClearPartyResponse> os, Action<ErrorType, int, WallGetWallClearPartyResponse> oe);
			internal IHttpTask _.cctor_b__55_258(WallReceiveMonthlyRewardRequest res, Action<WallReceiveMonthlyRewardResponse> os, Action<ErrorType, int, WallReceiveMonthlyRewardResponse> oe);
			internal IHttpTask _.cctor_b__55_259(WallRecordRecordRequest res, Action<WallRecordRecordResponse> os, Action<ErrorType, int, WallRecordRecordResponse> oe);
			internal IHttpTask _.cctor_b__55_260(WallSetWallClearPartyRequest res, Action<WallSetWallClearPartyResponse> os, Action<ErrorType, int, WallSetWallClearPartyResponse> oe);
			internal IHttpTask _.cctor_b__55_261(WallStartStartRequest res, Action<WallStartStartResponse> os, Action<ErrorType, int, WallStartStartResponse> oe);
			internal IHttpTask _.cctor_b__55_262(WallStartStartAssignUnitRequest res, Action<WallStartStartAssignUnitResponse> os, Action<ErrorType, int, WallStartStartAssignUnitResponse> oe);
			internal IHttpTask _.cctor_b__55_263(WeaponBodyBuildupPieceRequest res, Action<WeaponBodyBuildupPieceResponse> os, Action<ErrorType, int, WeaponBodyBuildupPieceResponse> oe);
			internal IHttpTask _.cctor_b__55_264(WeaponBodyCraftRequest res, Action<WeaponBodyCraftResponse> os, Action<ErrorType, int, WeaponBodyCraftResponse> oe);
			internal IHttpTask _.cctor_b__55_265(WeaponBuildupRequest res, Action<WeaponBuildupResponse> os, Action<ErrorType, int, WeaponBuildupResponse> oe);
			internal IHttpTask _.cctor_b__55_266(WeaponLimitBreakRequest res, Action<WeaponLimitBreakResponse> os, Action<ErrorType, int, WeaponLimitBreakResponse> oe);
			internal IHttpTask _.cctor_b__55_267(WeaponResetPlusCountRequest res, Action<WeaponResetPlusCountResponse> os, Action<ErrorType, int, WeaponResetPlusCountResponse> oe);
			internal IHttpTask _.cctor_b__55_268(WeaponSellRequest res, Action<WeaponSellResponse> os, Action<ErrorType, int, WeaponSellResponse> oe);
			internal IHttpTask _.cctor_b__55_269(WeaponSetLockRequest res, Action<WeaponSetLockResponse> os, Action<ErrorType, int, WeaponSetLockResponse> oe);
			internal IHttpTask _.cctor_b__55_270(WebviewVersionUrlListRequest res, Action<WebviewVersionUrlListResponse> os, Action<ErrorType, int, WebviewVersionUrlListResponse> oe);
			internal IHttpTask _.cctor_b__55_271(DebugAbilityCrestAddAbilityCrestRequest res, Action<DebugAbilityCrestAddAbilityCrestResponse> os, Action<ErrorType, int, DebugAbilityCrestAddAbilityCrestResponse> oe);
			internal IHttpTask _.cctor_b__55_272(DebugAbilityCrestAddAllRequest res, Action<DebugAbilityCrestAddAllResponse> os, Action<ErrorType, int, DebugAbilityCrestAddAllResponse> oe);
			internal IHttpTask _.cctor_b__55_273(DebugAmuletAddAllRequest res, Action<DebugAmuletAddAllResponse> os, Action<ErrorType, int, DebugAmuletAddAllResponse> oe);
			internal IHttpTask _.cctor_b__55_274(DebugAmuletAddAmuletRequest res, Action<DebugAmuletAddAmuletResponse> os, Action<ErrorType, int, DebugAmuletAddAmuletResponse> oe);
			internal IHttpTask _.cctor_b__55_275(DebugAstralItemAddAstralItemRequest res, Action<DebugAstralItemAddAstralItemResponse> os, Action<ErrorType, int, DebugAstralItemAddAstralItemResponse> oe);
			internal IHttpTask _.cctor_b__55_276(DebugAstralItemAddAstralItemAllRequest res, Action<DebugAstralItemAddAstralItemAllResponse> os, Action<ErrorType, int, DebugAstralItemAddAstralItemAllResponse> oe);
			internal IHttpTask _.cctor_b__55_277(DebugAstralItemUpdateAstralItemRequest res, Action<DebugAstralItemUpdateAstralItemResponse> os, Action<ErrorType, int, DebugAstralItemUpdateAstralItemResponse> oe);
			internal IHttpTask _.cctor_b__55_278(DebugBattleRoyalEventAllReleaseRequest res, Action<DebugBattleRoyalEventAllReleaseResponse> os, Action<ErrorType, int, DebugBattleRoyalEventAllReleaseResponse> oe);
			internal IHttpTask _.cctor_b__55_279(DebugCharaAddAllRequest res, Action<DebugCharaAddAllResponse> os, Action<ErrorType, int, DebugCharaAddAllResponse> oe);
			internal IHttpTask _.cctor_b__55_280(DebugCharaAddCharaRequest res, Action<DebugCharaAddCharaResponse> os, Action<ErrorType, int, DebugCharaAddCharaResponse> oe);
			internal IHttpTask _.cctor_b__55_281(DebugCharaUpdateUnlockEditSkillAllRequest res, Action<DebugCharaUpdateUnlockEditSkillAllResponse> os, Action<ErrorType, int, DebugCharaUpdateUnlockEditSkillAllResponse> oe);
			internal IHttpTask _.cctor_b__55_282(DebugCombatEventUpdateEventDataAllRequest res, Action<DebugCombatEventUpdateEventDataAllResponse> os, Action<ErrorType, int, DebugCombatEventUpdateEventDataAllResponse> oe);
			internal IHttpTask _.cctor_b__55_283(DebugCommonGetGeohashRequest res, Action<DebugCommonGetGeohashResponse> os, Action<ErrorType, int, DebugCommonGetGeohashResponse> oe);
			internal IHttpTask _.cctor_b__55_284(DebugDebugTimeGetDebugTimeRequest res, Action<DebugDebugTimeGetDebugTimeResponse> os, Action<ErrorType, int, DebugDebugTimeGetDebugTimeResponse> oe);
			internal IHttpTask _.cctor_b__55_285(DebugDragonAddAllRequest res, Action<DebugDragonAddAllResponse> os, Action<ErrorType, int, DebugDragonAddAllResponse> oe);
			internal IHttpTask _.cctor_b__55_286(DebugDragonAddDragonRequest res, Action<DebugDragonAddDragonResponse> os, Action<ErrorType, int, DebugDragonAddDragonResponse> oe);
			internal IHttpTask _.cctor_b__55_287(DebugDragonResetDragonGiftShopRequest res, Action<DebugDragonResetDragonGiftShopResponse> os, Action<ErrorType, int, DebugDragonResetDragonGiftShopResponse> oe);
			internal IHttpTask _.cctor_b__55_288(DebugDragonUpdateCountContactRequest res, Action<DebugDragonUpdateCountContactResponse> os, Action<ErrorType, int, DebugDragonUpdateCountContactResponse> oe);
			internal IHttpTask _.cctor_b__55_289(DebugDragonUpdateDragonReliabilityAllRequest res, Action<DebugDragonUpdateDragonReliabilityAllResponse> os, Action<ErrorType, int, DebugDragonUpdateDragonReliabilityAllResponse> oe);
			internal IHttpTask _.cctor_b__55_290(DebugDungeonStartStartRequest res, Action<DebugDungeonStartStartResponse> os, Action<ErrorType, int, DebugDungeonStartStartResponse> oe);
			internal IHttpTask _.cctor_b__55_291(DebugDungeonStartStartAssignSupportRequest res, Action<DebugDungeonStartStartAssignSupportResponse> os, Action<ErrorType, int, DebugDungeonStartStartAssignSupportResponse> oe);
			internal IHttpTask _.cctor_b__55_292(DebugDungeonStartStartAssignUnitRequest res, Action<DebugDungeonStartStartAssignUnitResponse> os, Action<ErrorType, int, DebugDungeonStartStartAssignUnitResponse> oe);
			internal IHttpTask _.cctor_b__55_293(DebugDungeonStartStartMultiRequest res, Action<DebugDungeonStartStartMultiResponse> os, Action<ErrorType, int, DebugDungeonStartStartMultiResponse> oe);
			internal IHttpTask _.cctor_b__55_294(DebugFirstMeetingAddRequest res, Action<DebugFirstMeetingAddResponse> os, Action<ErrorType, int, DebugFirstMeetingAddResponse> oe);
			internal IHttpTask _.cctor_b__55_295(DebugFirstMeetingResetRequest res, Action<DebugFirstMeetingResetResponse> os, Action<ErrorType, int, DebugFirstMeetingResetResponse> oe);
			internal IHttpTask _.cctor_b__55_296(DebugFortUpdateFortLevelRequest res, Action<DebugFortUpdateFortLevelResponse> os, Action<ErrorType, int, DebugFortUpdateFortLevelResponse> oe);
			internal IHttpTask _.cctor_b__55_297(DebugGuildUpdateUserRequest res, Action<DebugGuildUpdateUserResponse> os, Action<ErrorType, int, DebugGuildUpdateUserResponse> oe);
			internal IHttpTask _.cctor_b__55_298(DebugHunterEventUpdateEventDataAllRequest res, Action<DebugHunterEventUpdateEventDataAllResponse> os, Action<ErrorType, int, DebugHunterEventUpdateEventDataAllResponse> oe);
			internal IHttpTask _.cctor_b__55_299(DebugItemAddItemRequest res, Action<DebugItemAddItemResponse> os, Action<ErrorType, int, DebugItemAddItemResponse> oe);
			internal IHttpTask _.cctor_b__55_300(DebugMaterialAddMaterialRequest res, Action<DebugMaterialAddMaterialResponse> os, Action<ErrorType, int, DebugMaterialAddMaterialResponse> oe);
			internal IHttpTask _.cctor_b__55_301(DebugPartyGetPartyListRequest res, Action<DebugPartyGetPartyListResponse> os, Action<ErrorType, int, DebugPartyGetPartyListResponse> oe);
			internal IHttpTask _.cctor_b__55_302(DebugPartyPartySettingRequest res, Action<DebugPartyPartySettingResponse> os, Action<ErrorType, int, DebugPartyPartySettingResponse> oe);
			internal IHttpTask _.cctor_b__55_303(DebugPartySetMaxPartyPowerRequest res, Action<DebugPartySetMaxPartyPowerResponse> os, Action<ErrorType, int, DebugPartySetMaxPartyPowerResponse> oe);
			internal IHttpTask _.cctor_b__55_304(DebugPlatformInterfaceCallbackRequest res, Action<DebugPlatformInterfaceCallbackResponse> os, Action<ErrorType, int, DebugPlatformInterfaceCallbackResponse> oe);
			internal IHttpTask _.cctor_b__55_305(DebugPresentSetPresentRequest res, Action<DebugPresentSetPresentResponse> os, Action<ErrorType, int, DebugPresentSetPresentResponse> oe);
			internal IHttpTask _.cctor_b__55_306(DebugQuestClearAllRequest res, Action<DebugQuestClearAllResponse> os, Action<ErrorType, int, DebugQuestClearAllResponse> oe);
			internal IHttpTask _.cctor_b__55_307(DebugQuestClearQuestRequest res, Action<DebugQuestClearQuestResponse> os, Action<ErrorType, int, DebugQuestClearQuestResponse> oe);
			internal IHttpTask _.cctor_b__55_308(DebugQuestClearQuestEventCountRequest res, Action<DebugQuestClearQuestEventCountResponse> os, Action<ErrorType, int, DebugQuestClearQuestEventCountResponse> oe);
			internal IHttpTask _.cctor_b__55_309(DebugQuestDeleteAllRequest res, Action<DebugQuestDeleteAllResponse> os, Action<ErrorType, int, DebugQuestDeleteAllResponse> oe);
			internal IHttpTask _.cctor_b__55_310(DebugQuestReadStoryRequest res, Action<DebugQuestReadStoryResponse> os, Action<ErrorType, int, DebugQuestReadStoryResponse> oe);
			internal IHttpTask _.cctor_b__55_311(DebugQuestUpdateQuestIsAppearAllRequest res, Action<DebugQuestUpdateQuestIsAppearAllResponse> os, Action<ErrorType, int, DebugQuestUpdateQuestIsAppearAllResponse> oe);
			internal IHttpTask _.cctor_b__55_312(DebugRaidEventUpdateEventDataAllRequest res, Action<DebugRaidEventUpdateEventDataAllResponse> os, Action<ErrorType, int, DebugRaidEventUpdateEventDataAllResponse> oe);
			internal IHttpTask _.cctor_b__55_313(DebugSummonTicketAddSummonTicketAllRequest res, Action<DebugSummonTicketAddSummonTicketAllResponse> os, Action<ErrorType, int, DebugSummonTicketAddSummonTicketAllResponse> oe);
			internal IHttpTask _.cctor_b__55_314(DebugSummonTicketAddTicketRequest res, Action<DebugSummonTicketAddTicketResponse> os, Action<ErrorType, int, DebugSummonTicketAddTicketResponse> oe);
			internal IHttpTask _.cctor_b__55_315(DebugUserAddFreeStoneRequest res, Action<DebugUserAddFreeStoneResponse> os, Action<ErrorType, int, DebugUserAddFreeStoneResponse> oe);
			internal IHttpTask _.cctor_b__55_316(DebugUserGetDiamondRequest res, Action<DebugUserGetDiamondResponse> os, Action<ErrorType, int, DebugUserGetDiamondResponse> oe);
			internal IHttpTask _.cctor_b__55_317(DebugUserIncreaseCoinRequest res, Action<DebugUserIncreaseCoinResponse> os, Action<ErrorType, int, DebugUserIncreaseCoinResponse> oe);
			internal IHttpTask _.cctor_b__55_318(DebugUserIncreaseCrystalRequest res, Action<DebugUserIncreaseCrystalResponse> os, Action<ErrorType, int, DebugUserIncreaseCrystalResponse> oe);
			internal IHttpTask _.cctor_b__55_319(DebugUserIncreaseDewPointRequest res, Action<DebugUserIncreaseDewPointResponse> os, Action<ErrorType, int, DebugUserIncreaseDewPointResponse> oe);
			internal IHttpTask _.cctor_b__55_320(DebugUserIncreaseDiamondRequest res, Action<DebugUserIncreaseDiamondResponse> os, Action<ErrorType, int, DebugUserIncreaseDiamondResponse> oe);
			internal IHttpTask _.cctor_b__55_321(DebugUserIncreaseQuestSkipPointRequest res, Action<DebugUserIncreaseQuestSkipPointResponse> os, Action<ErrorType, int, DebugUserIncreaseQuestSkipPointResponse> oe);
			internal IHttpTask _.cctor_b__55_322(DebugUserRecoverStaminaMultiRequest res, Action<DebugUserRecoverStaminaMultiResponse> os, Action<ErrorType, int, DebugUserRecoverStaminaMultiResponse> oe);
			internal IHttpTask _.cctor_b__55_323(DebugUserRecoverStaminaSingleRequest res, Action<DebugUserRecoverStaminaSingleResponse> os, Action<ErrorType, int, DebugUserRecoverStaminaSingleResponse> oe);
			internal IHttpTask _.cctor_b__55_324(DebugUserUpdateCrystalRequest res, Action<DebugUserUpdateCrystalResponse> os, Action<ErrorType, int, DebugUserUpdateCrystalResponse> oe);
			internal IHttpTask _.cctor_b__55_325(DebugUserUpdateDewPointRequest res, Action<DebugUserUpdateDewPointResponse> os, Action<ErrorType, int, DebugUserUpdateDewPointResponse> oe);
			internal IHttpTask _.cctor_b__55_326(DebugUserUpdateManaPointRequest res, Action<DebugUserUpdateManaPointResponse> os, Action<ErrorType, int, DebugUserUpdateManaPointResponse> oe);
			internal IHttpTask _.cctor_b__55_327(DebugUserUpdateQuestSkipPointRequest res, Action<DebugUserUpdateQuestSkipPointResponse> os, Action<ErrorType, int, DebugUserUpdateQuestSkipPointResponse> oe);
			internal IHttpTask _.cctor_b__55_328(DebugUserUpdateTutorialFlagsRequest res, Action<DebugUserUpdateTutorialFlagsResponse> os, Action<ErrorType, int, DebugUserUpdateTutorialFlagsResponse> oe);
			internal IHttpTask _.cctor_b__55_329(DebugUserUpdateTutorialStatusRequest res, Action<DebugUserUpdateTutorialStatusResponse> os, Action<ErrorType, int, DebugUserUpdateTutorialStatusResponse> oe);
			internal IHttpTask _.cctor_b__55_330(DebugUserUserExpRequest res, Action<DebugUserUserExpResponse> os, Action<ErrorType, int, DebugUserUserExpResponse> oe);
			internal IHttpTask _.cctor_b__55_331(DebugUserUserRankRequest res, Action<DebugUserUserRankResponse> os, Action<ErrorType, int, DebugUserUserRankResponse> oe);
			internal IHttpTask _.cctor_b__55_332(DebugWeaponAddAllRequest res, Action<DebugWeaponAddAllResponse> os, Action<ErrorType, int, DebugWeaponAddAllResponse> oe);
			internal IHttpTask _.cctor_b__55_333(DebugWeaponAddWeaponRequest res, Action<DebugWeaponAddWeaponResponse> os, Action<ErrorType, int, DebugWeaponAddWeaponResponse> oe);
			internal IHttpTask _.cctor_b__55_334(DebugWeaponBodyAddAllRequest res, Action<DebugWeaponBodyAddAllResponse> os, Action<ErrorType, int, DebugWeaponBodyAddAllResponse> oe);
			internal IHttpTask _.cctor_b__55_335(DebugWeaponBodyAddWeaponBodyRequest res, Action<DebugWeaponBodyAddWeaponBodyResponse> os, Action<ErrorType, int, DebugWeaponBodyAddWeaponBodyResponse> oe);
			internal IHttpTask _.cctor_b__55_336(DebugWeaponSkinAddAllRequest res, Action<DebugWeaponSkinAddAllResponse> os, Action<ErrorType, int, DebugWeaponSkinAddAllResponse> oe);
			internal IHttpTask _.cctor_b__55_337(DebugWeaponSkinAddWeaponSkinRequest res, Action<DebugWeaponSkinAddWeaponSkinResponse> os, Action<ErrorType, int, DebugWeaponSkinAddWeaponSkinResponse> oe);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public InquiryPopup popup;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _ShowInquiryPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public int requestTime;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _OnError_b__0();
			internal void _OnError_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public DataManager dataManager;
			public Action next;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _Auth_b__0(ToolAuthResponse res);
			internal void _Auth_b__1(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public DataManager dataManager;
			public Action next;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _ReAuth_b__0(ToolReauthResponse res);
			internal void _ReAuth_b__1(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public Action next;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _UpdatePushNotificationInfo_b__0(PushNotificationUpdateSettingResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public Action next;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _GetResourceVersion_b__0(VersionGetResourceVersionResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public Action next;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _Signup_b__0(ToolSignupResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public Action next;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _LoadIndex_b__0(LoadIndexResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public Action next;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _LoginIndex_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public Action<Action, Action<ErrorType, int>, string> callback;
			public Action next;
			public Action<ErrorType, int> onError;
			public Action<string> onCallback;
			public Action<string> __9__3;
			public Action<string> __9__4;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _GetSafetyNetStatus_b__0(ErrorType errorType, int resultCode);
			internal void _GetSafetyNetStatus_b__1(string res);
			internal void _GetSafetyNetStatus_b__2();
			internal void _GetSafetyNetStatus_b__3(string response);
			internal void _GetSafetyNetStatus_b__4(string errorMsg);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal void _SendLoginIndex_b__0(LoginIndexResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal void _SendLoginVerifyJws_b__0(LoginVerifyJwsResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public Action next;
			public Action __9__2;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _Login_b__0();
			internal void _Login_b__1();
			internal void _Login_b__2();
		}
	
		// Constructors
		static HttpHelper();
		public HttpHelper();
	
		// Methods
		private static long GenerateRequestToken();
		private static int GetRequestTime(long token);
		private static bool IsRetryAvailable(int n);
		public static T Create<T>()
			where T : new();
		public static void Send<T1, T2>(T1 req, Action<T2> onSuccess, Action<ErrorType, int> onError = null, bool auth = false)
			where T2 : class;
		public static void SendSilently<T1, T2>(T1 req, Action<T2> onSuccess, bool auth = false)
			where T2 : class;
		private static void Send<T1, T2>(T1 req, bool ignoreError, bool createOnConnectCanvas, Action<T2> onSuccess, Action<ErrorType, int> onError = null, bool auth = false)
			where T2 : class;
		public static Task<T2> SendAsync<T1, T2>(T1 req, Action<ErrorType, int> onError = null, bool auth = false)
			where T2 : class;
		public static Task<T2> SendSilentlyAsync<T1, T2>(T1 req, bool auth = false)
			where T2 : class;
		private static Task<T2> SendAsync<T1, T2>(T1 req, bool ignoreError = false, bool createOnConnectCanvas = true, Action<ErrorType, int> onError = null, bool auth = false)
			where T2 : class;
		[IteratorStateMachine]
		private static IEnumerator DelayOneSec(Action next);
		private static void OpenOnConnectCanvas();
		private static void CloseOnConnectCanvas();
		public static void BackToTitle();
		public static void BackToMyPage();
		public static void BackToParty();
		public static void BackToDownload();
		public static void BackToQuit();
		public static void GoToLoginBonus();
		private static void ShowInquiryPopup();
		public static SystemMessageElement GetSystemMessageElement(int resultCode);
		public static Action GetAction(int resultCode);
		private static void Retry(int requestTime);
		public static void OnError(ErrorType type, int n, Action<ErrorType, int> onError = null);
		private static void NpfBaaSAuthCallback(BaaSUser user, NPFError error);
		private static void NpfBaaSReauthCallback(BaaSUser user, NPFError error);
		private static void ApplicationVersionError();
		public static void ClearCache<T>()
			where T : IHttpTask;
		public static void Auth(Action next = null, bool force = false, bool interruptAuthTask = false);
		private static void ReAuth(Action next = null);
		public static void UpdatePushNotificationInfo(Action next);
		public static bool IsAssetBundleBuildNumberSpecifiedByDebugCommand();
		public static string GetAssetBundleBuildNumber();
		public static void GetResourceVersion(Action next);
		public static void Signup(Action next, string lang = "ja_jp", string region = "JP", int eulaVersion = 1, int privacyVersion = 1);
		public static void SetupDefaultHeader();
		public static void LoadIndex(Action next);
		public static void LoginIndex(Action next, bool afterPrologue = false);
		private static void GetSafetyNetStatus(Action<Action, Action<ErrorType, int>, string> callback, Action next);
		private static void SendLoginIndex(Action onSuccess, Action<ErrorType, int> onError = null, string jws_result = null);
		private static void SendLoginVerifyJws(Action onSuccess, Action<ErrorType, int> onError, string jws_result);
		public static void LoginVerifyJws(Action next, string jws_result = null);
		public static void Login(Action next);
		private static void OnUnableToContinueError();
		private static void PauseIngame(bool pause);
		private static bool IsNoSessionApi(Type taskType);
	}
}
