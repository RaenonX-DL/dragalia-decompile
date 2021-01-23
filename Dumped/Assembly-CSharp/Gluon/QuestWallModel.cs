/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestWallModel
	{
		// Fields
		private static QuestWallModel instance;
		public static readonly string questWallPopupPath;
		public static readonly string questWallClearAllLvPopupPath;
		public static readonly string questWallTotalRewardPopupPath;
		public static readonly string questWallContinuityCheckPopupPath;
		public static readonly string questWallGetRewardPopupPath;
		public static readonly string questWallTotalLv;
		public static readonly string questWalllLogo;
		public static readonly string topPagePrefabPath;
		public static readonly string prefabPath;
		public static readonly string flashFafnirRoyPrefabPath;
		public static readonly string flashHeaderCharacter;
		public static readonly string flashNextitem;
		public static readonly string flashGetItem;
		public static readonly string flashEffect;
		public static readonly string fafnirroyCompletePath;
		public static int questWallBannerType;
		public static readonly int questWallItemGetDay;
		public static readonly int questWallEffectiveAbnormalStateA;
		public static readonly int questWallEffectiveAbnormalStateB;
		public static readonly int questWallEffectiveAbnormalStateC;
		public static readonly int questCharacterMaxCount;
		private int wallId;
		private static bool isLastWallClear;
		public int sumLevel;
		public List<QuestWallData> questWallDataList;
		public List<QuestWallRewardData> questWallRewardDataList;
		public static bool isMaxWallClear;
		[CompilerGenerated]
		private int _PlayWallLevel_k__BackingField;
		[CompilerGenerated]
		private bool _IsSameQuest_k__BackingField;
		[CompilerGenerated]
		private int _gainMana_k__BackingField;
		[CompilerGenerated]
		private int _gainGold_k__BackingField;
		[CompilerGenerated]
		private int _playerExp_k__BackingField;
		[CompilerGenerated]
		private int _gainPlayerExp_k__BackingField;
		[CompilerGenerated]
		private int _gainCharacterExp_k__BackingField;
		[CompilerGenerated]
		private bool _isGetItem_k__BackingField;
		[CompilerGenerated]
		private int _effectStage_k__BackingField;
		public List<QuestResultModel.TopPageModel.RewardItemInfo> wallDropRewardList;
		public List<QuestResultModel.FirstClearModel.FirstClearItemInfo> firstClearItemList;
		public List<QuestResultModel.FirstClearModel.FirstClearItemInfo> firstClearCharaList;
		public List<QuestResultModel.FirstClearModel.FirstClearItemInfo> firstClearDragonList;
		public QuestResultModel.TopPageModel.CharacterInfo[] characterList;
		public List<QuestResultModel.FriendApplyModel.SingleFriendApplyInfo> supportList;
		public QuestPrepareData[] questPrepareData;
		public readonly string prefsKeyElement;
		public List<string> releaseTextList;
		[CompilerGenerated]
		private bool _isReleaseMaxLevelPopup_k__BackingField;
	
		// Properties
		public static QuestWallModel Instance { get; }
		public bool IsMonthlyWallReceive { get; }
		public int WallId { get; set; }
		public int PlayWallLevel { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsSameQuest { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsLastWallClear { get; set; }
		public int gainMana { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int gainGold { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int playerExp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int gainPlayerExp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int gainCharacterExp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isGetItem { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int effectStage { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isReleaseMaxLevelPopup { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public class QuestWallData
		{
			// Fields
			public int wallId;
			public int wallLevel;
			public ElementalType elementType;
			public bool isIsStartNextLevel;
	
			// Constructors
			public QuestWallData();
		}
	
		public class QuestWallRewardData
		{
			// Fields
			public GiftType giftType;
			public int rewardId;
			public int rewardQuantity;
			public bool isShowBadge;
			public string rewardName;
	
			// Constructors
			public QuestWallRewardData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass98_0
		{
			// Fields
			public Action<int> onCompleted;
			public int groupId;
	
			// Constructors
			public __c__DisplayClass98_0();
	
			// Methods
			internal void _RequestWallReceiveMonthlyReward_b__0(WallReceiveMonthlyRewardResponse response);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<QuestWallElement> __9__103_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _GetUserWalllevelList_b__103_0(QuestWallElement a, QuestWallElement b);
		}
	
		// Constructors
		private QuestWallModel();
		static QuestWallModel();
	
		// Methods
		public static void DeleteInstance();
		public void Clear();
		public void Load();
		public void SetQuestWallRewardDataList();
		public void ReleaseMaxLevelPopupOpen();
		public bool IsQuestWallResult();
		private void QuestWallResultClear();
		public void QuestWallResultLoad();
		public static QuestWallList GetQuestWallList(int wallId);
		public static void RequestWallReceiveMonthlyReward(int groupId, Action<int> onCompleted, Action<ErrorType, int> onError = null);
		public static int GetQuestWallLevel(int questid);
		public static int GetQuestWallSumLevel();
		public static int GetLastSumLevel();
		public static bool IsUserWallRewardListRewardStatus();
		public static int[] GetUserWalllevelList(int groupId);
		public static bool IsAllClear(int wallId);
		public void InitDebugData();
		public List<string> CheckUpdateMaxLevel();
	}
}
