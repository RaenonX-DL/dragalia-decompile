/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BattleRoyalModel
	{
		// Fields
		private static BattleRoyalModel instance;
		private const string prefsJobSettingTemplate = "__BR_JobSettingDic_{0}";
		private const string prefsJobWeaponSettingTemplate = "__BR_JobWeaponSettingDic_{0}";
	
		// Properties
		public static BattleRoyalModel Instance { get; }
		public List<WeaponType> weaponTypeList { get; }
		public List<int> charaSkinList { get; }
		public Dictionary<WeaponType, int> jobSettingDic { get; }
		public Dictionary<WeaponType, int> jobWeaponSettingDic { get; }
		public int totalTop1Count { get; }
		public int totalTop4Count { get; }
		public WeaponType mostUsedJob { get; }
		public int killTotalCount { get; }
		public int maxKillCountPerGame { get; }
		public int currentPoint { get; }
		public int cyclePoint { get; }
		public int totalPoint { get; }
		public List<BattleRecord> battleRecordList { get; }
		public static int eventId { get; }
		public static int questId { get; }
	
		// Nested types
		public class BattleRecord
		{
			// Fields
			public int rank;
			public int kill;
			public int dateTime;
			public int skinOrCharaId;
			public WeaponType job;
	
			// Constructors
			public BattleRecord();
		}
	
		public enum TalkDataCategory
		{
			Top = 1,
			Result = 2,
			Hint = 3,
			JobDescription = 4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			[TupleElementNames]
			public static Func<ValueTuple<WeaponType, int>, int> __9__24_0;
			[TupleElementNames]
			public static Func<ValueTuple<WeaponType, int>, bool> __9__24_1;
			public static Func<BattleRecord, int> __9__37_0;
			public static Func<QuestScheduleDataWrapper, DateTime> __9__42_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _get_mostUsedJob_b__24_0([TupleElementNames] ValueTuple<WeaponType, int> x);
			internal bool _get_mostUsedJob_b__24_1([TupleElementNames] ValueTuple<WeaponType, int> x);
			internal int _get_battleRecordList_b__37_0(BattleRecord x);
			internal DateTime _GetCurrentOrNextAvailableDateTime_b__42_1(QuestScheduleDataWrapper x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public int qId;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal bool _GetCurrentOrNextAvailableDateTime_b__0(QuestScheduleDataWrapper x);
		}
	
		[CompilerGenerated]
		private struct _SendReleaseCharaSkinData_d__47 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int charaSkinId;
			public Action<int> onComplete;
			private TaskAwaiter<BattleRoyalEventReleaseCharaSkinResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		private BattleRoyalModel();
		static BattleRoyalModel();
	
		// Methods
		public static void DeleteInstance();
		public static bool IsInstanceNull();
		public void SetJobSetting(WeaponType weaponType, int skinId);
		public void SetJobWeaponSetting(WeaponType weaponType, int skinId);
		public static bool GetCurrentOrNextAvailableDateTime(out DateTime startTime, out DateTime endTime);
		public List<BattleRoyalEventItemElement> GetEnabledSkinListForType(WeaponType wt);
		public string GetHintMessage();
		public static bool IsPickupCharaSkin(int charaSkinId);
		public async void SendReleaseCharaSkinData(int charaSkinId, Action<int> onComplete);
	}
}
