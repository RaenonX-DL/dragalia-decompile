/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class QuestApiService
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public Action onSuccess;
			public Action<ErrorType, int> onError;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void __StartSinglePlayQuestApi_Common_b__0(DungeonSkipStartResponse res);
			internal void __StartSinglePlayQuestApi_Common_b__1(ErrorType errorType, int resultCode);
			internal void __StartSinglePlayQuestApi_Common_b__2(WallStartStartResponse res);
			internal void __StartSinglePlayQuestApi_Common_b__3(ErrorType errorType, int resultCode);
			internal void __StartSinglePlayQuestApi_Common_b__4(DungeonStartStartResponse res);
			internal void __StartSinglePlayQuestApi_Common_b__5(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public bool isSkip;
			public Action onError;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _StartSinglePlayQuestApi_b__0(ErrorType errorType, int resultCode);
			internal void _StartSinglePlayQuestApi_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public bool isSkip;
			public Action<ErrorType, int> onError;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _StartSinglePlayQuestApi_b__0(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public Action onSuccess;
			public Action onError;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _StartSinglePlayQuestApiWithClearParty_b__0(DungeonSkipStartAssignUnitResponse res);
			internal void _StartSinglePlayQuestApiWithClearParty_b__1(ErrorType errorType, int resultCode);
			internal void _StartSinglePlayQuestApiWithClearParty_b__2(WallStartStartAssignUnitResponse res);
			internal void _StartSinglePlayQuestApiWithClearParty_b__3(ErrorType errorType, int resultCode);
			internal void _StartSinglePlayQuestApiWithClearParty_b__4(DungeonStartStartAssignUnitResponse res);
			internal void _StartSinglePlayQuestApiWithClearParty_b__5(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public Action onSuccess;
			public Action<ErrorType, int> onError;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _StartSinglePlayQuestApiWithClearParty_b__0(DungeonSkipStartAssignUnitResponse res);
			internal void _StartSinglePlayQuestApiWithClearParty_b__1(ErrorType errorType, int resultCode);
			internal void _StartSinglePlayQuestApiWithClearParty_b__2(WallStartStartAssignUnitResponse res);
			internal void _StartSinglePlayQuestApiWithClearParty_b__3(ErrorType errorType, int resultCode);
			internal void _StartSinglePlayQuestApiWithClearParty_b__4(DungeonStartStartAssignUnitResponse res);
			internal void _StartSinglePlayQuestApiWithClearParty_b__5(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public Action onError;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _OnErrorSinglePlayWithClearParty_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public Action onSuccess;
			public Action onError;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _StartMultiPlayQuestApi_b__0(DungeonStartStartMultiResponse res);
			internal void _StartMultiPlayQuestApi_b__1(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public Action onSuccess;
			public Action onError;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _StartMultiPlayBattleRoyalApi_b__0(BattleRoyalStartRoyalMultiResponse res);
			internal void _StartMultiPlayBattleRoyalApi_b__1(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public Action onSuccess;
			public Action onError;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _StartMultiPlayQuestApiWithClearParty_b__0(DungeonStartStartMultiAssignUnitResponse res);
			internal void _StartMultiPlayQuestApiWithClearParty_b__1(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public Action onError;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _OnErrorMultiPlay_b__0();
		}
	
		// Methods
		private static void _StartSinglePlayQuestApi_Common(int questId, ulong supportUserId, int playCount, Action onSuccess, Action<ErrorType, int> onError, bool isSkip = false, bool isCheckDateChange = false);
		public static void StartSinglePlayQuestApi(int questId, ulong supportUserId, int playCount, Action onSuccess, Action onError, bool isSkip = false);
		public static void StartSinglePlayQuestApi(int questId, ulong supportUserId, int playCount, Action onSuccess, Action<ErrorType, int> onError, bool isSkip = false);
		private static void OnSuccessSinglePlay(DungeonStartStartResponse res, Action onSuccess);
		private static void OnSuccessSinglePlay(WallStartStartResponse res, Action onSuccess);
		private static void OnSuccessSkipSinglePlay(DungeonSkipStartResponse res, Action onSuccess);
		public static void StartSinglePlayQuestApiWithClearParty(int questId, ulong supportUserId, int playCount, QuestPrepareData[] clearPartyDatas, Action onSuccess, Action onError, bool isSkip = false);
		public static void StartSinglePlayQuestApiWithClearParty(int questId, ulong supportUserId, int playCount, QuestPrepareData[] clearPartyDatas, Action onSuccess, Action<ErrorType, int> onError, bool isSkip = false);
		private static void OnSuccessSinglePlayWithClearParty(DungeonStartStartAssignUnitResponse res, Action onSuccess);
		private static void OnSuccessSinglePlayWithClearParty(WallStartStartAssignUnitResponse res, Action onSuccess);
		private static void OnSuccessSkipSinglePlayWithClearParty(DungeonSkipStartAssignUnitResponse res, Action onSuccess);
		private static void OnErrorSinglePlayWithClearParty(ErrorType errorType, int resultCode, Action onError, bool isSkip = false);
		private static void OnErrorSinglePlayWithClearParty(ErrorType errorType, int resultCode, Action<ErrorType, int> onError, bool isSkip = false);
		public static void StartMultiPlayQuestApi(int questId, int[] usePartySlots, Action onSuccess, Action onError);
		public static void StartMultiPlayBattleRoyalApi(int questId, Action onSuccess, Action onError);
		public static void StartMultiPlayQuestApiWithClearParty(int questId, QuestPrepareData[] clearPartyDatas, Action onSuccess, Action onError);
		private static int GetQuestStartRepeatState();
		private static void OnSuccessMultiPlay(DungeonStartStartMultiResponse res, Action onSuccess);
		private static void OnSuccessMultiPlay(DungeonStartStartMultiAssignUnitResponse res, Action onSuccess);
		private static void OnSuccessMultiPlay(BattleRoyalStartRoyalMultiResponse res, Action onSuccess);
		private static void OnErrorMultiPlay(ErrorType errorType, int resultCode, Action onError);
	}
}
