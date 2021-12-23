using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Http;
using Gluon.Http;

namespace Gluon
{
	public class QuestWallModel
	{
		public class QuestWallData
		{
			public int wallId;

			public int wallLevel;

			public ElementalType elementType;

			public bool isIsStartNextLevel;
		}

		public class QuestWallRewardData
		{
			public GiftType giftType;

			public int rewardId;

			public int rewardQuantity;

			public bool isShowBadge;

			public string rewardName;
		}

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

		public static bool canChallengeNextQuest;

		public List<QuestResultModel.TopPageModel.RewardItemInfo> wallDropRewardList;

		public List<QuestResultModel.FirstClearModel.FirstClearItemInfo> firstClearItemList;

		public List<QuestResultModel.FirstClearModel.FirstClearItemInfo> firstClearCharaList;

		public List<QuestResultModel.FirstClearModel.FirstClearItemInfo> firstClearDragonList;

		public QuestResultModel.TopPageModel.CharacterInfo[] characterList;

		public List<QuestResultModel.FriendApplyModel.SingleFriendApplyInfo> supportList;

		public QuestPrepareData[] questPrepareData;

		public readonly string prefsKeyElement;

		public List<string> releaseTextList;

		public static QuestWallModel Instance => null;

		public bool IsMonthlyWallReceive => default(bool);

		public int WallId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int PlayWallLevel
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsSameQuest
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsLastWallClear
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int gainMana
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int gainGold
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int playerExp
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int gainPlayerExp
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int gainCharacterExp
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isReceivedOverLimitMana
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isReceivedOverLimitGold
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isGetItem
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int effectStage
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isReleaseMaxLevelPopup
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void DeleteInstance()
		{
		}

		private QuestWallModel()
		{
		}

		static QuestWallModel()
		{
		}

		public void Clear()
		{
		}

		public void Load()
		{
		}

		public void SetQuestWallRewardDataList()
		{
		}

		public void ReleaseMaxLevelPopupOpen()
		{
		}

		public bool IsQuestWallResult()
		{
			return default(bool);
		}

		private void QuestWallResultClear()
		{
		}

		public void QuestWallResultLoad()
		{
		}

		public static QuestWallList GetQuestWallList(int wallId)
		{
			return null;
		}

		public static void RequestWallReceiveMonthlyReward(int groupId, Action<int> onCompleted, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static int GetQuestWallLevel(int questid)
		{
			return default(int);
		}

		public static int GetQuestWallSumLevel()
		{
			return default(int);
		}

		public static int GetLastSumLevel()
		{
			return default(int);
		}

		public static bool IsUserWallRewardListRewardStatus()
		{
			return default(bool);
		}

		public static int[] GetUserWalllevelList(int groupId)
		{
			return null;
		}

		public static bool IsAllClear(int wallId)
		{
			return default(bool);
		}

		public void InitDebugData()
		{
		}

		public List<string> CheckUpdateMaxLevel()
		{
			return null;
		}
	}
}
