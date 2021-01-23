/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestRepeatSettingModel
	{
		// Fields
		private static QuestRepeatSettingModel instance;
		public RepeatSetting setting;
		public int userSetCount;
		public List<int> enabledAutoUseItemIdList;
		public const int maxTargetCount = 99;
		[CompilerGenerated]
		private int _finishedCount_k__BackingField;
		[CompilerGenerated]
		private bool _shouldTerminateNextResult_k__BackingField;
		public const float autoContinueCountdown = 3.5f;
		private List<AtgenBuildEventRewardEntityList> overDiscardEntityList;
		private List<AtgenBuildEventRewardEntityList> overPresentEntityList;
	
		// Properties
		public static QuestRepeatSettingModel Instance { get; }
		public static bool HasInstance { get; }
		public int TargetCount { get; }
		public int finishedCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool shouldTerminateNextResult { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum RepeatSetting
		{
			Off = 0,
			UseAllStamina = 1,
			Specified = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public QuestRepeatSettingModel model;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _Clone_b__0(int x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public int masterId;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal bool _GetNeedUseItemListForStamina_b__0(ItemList x);
		}
	
		// Constructors
		private QuestRepeatSettingModel();
		static QuestRepeatSettingModel();
	
		// Methods
		public static void DeleteInstance();
		public static QuestRepeatSettingModel CloneInstance();
		public QuestRepeatSettingModel Clone();
		private void RecordOverLimitByData(DataManager.GameData<AtgenBuildEventRewardEntityList> dmList, ref List<AtgenBuildEventRewardEntityList> selfList);
		public void RecordOverLimit();
		public void RestoreOverLimit();
		public static void Save(QuestRepeatSettingModel src);
		public static bool IsRepeatOn();
		public static RepeatSetting GetRepeatSetting();
		public static void OnInGameOnOffButtonToggled(bool toOn);
		public bool AddSpecifiedLoopCountAndCheckQuit();
		public bool IsStaminaEnoughForNextLoop(int requiredStamina);
		public List<AtgenUseItemList> GetNeedUseItemListForStamina(int requiredStamina);
	}
}
