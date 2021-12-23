using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using UnityEngine.Events;

namespace Gluon
{
	public class DmodeModel
	{
		public struct DmodeInfoData
		{
			public int totalMaxFloorNum;

			public int recoveryCount;

			public int recoveryTime;

			public int floorSkipCount;

			public int floorSkipTime;

			public int dmodePoint1;

			public int dmodePoint2;

			public int expeditionMaxFloor;

			public int expeditionTotalSecond;

			public bool isExpeditionStarted;

			public DateTime expeditionStartTime;
		}

		public class DmodeCharaListData
		{
			public int maxFloorNum;

			public int editSkillCharaId1;

			public int editSkillCharaId2;

			public int editSkillCharaId3;

			public int maxDmodeScore;

			public DmodeServitorType dmodeServitorType;
		}

		public struct DmodeDungeonInfoData
		{
			public int charaId;

			public int floorNum;

			public int questTime;

			public int dungeonScore;

			public int state;
		}

		public class DmodeServitorPassiveData
		{
			public int passiveNo;

			public int passiveLevel;

			public int sortId;
		}

		public enum DungeonState
		{
			STATE_NONE,
			STATE_WAITING,
			STATE_WAITING_INIT_END,
			STATE_WAITING_SKIP,
			STATE_WAITING_SKIP_END,
			STATE_PLAYING,
			STATE_HALTING,
			STATE_RESTART_END
		}

		public enum ExpeditionState
		{
			STATE_WAITING = 1,
			STATE_PLAYING
		}

		private static DmodeModel instance;

		public const int prologueId = 2310101;

		public const int questEventGroupId = 23101;

		public const int questEventId = 23101;

		public const int TreasureTradeGroupId = 1012;

		public const int dModePointId = 10001;

		public const int dModePointRareId = 10002;

		public const int dModeCharaLevel = 1;

		public const int dModeMaxFloor = 50;

		public const DmodeServitorType defaultDmodeServitorType = DmodeServitorType.DEFENSE;

		private QuestEventGroupElement questEventGroupElement;

		private DmodeSettingElement dmodeSetting;

		public DmodeInfoData dModeInfoModel;

		public Dictionary<int, DmodeCharaListData> dmodeCharaDic;

		public DmodeDungeonInfoData dmodeDungeonInfoData;

		public Dictionary<int, DmodeServitorPassiveData> dmodeServitorPassiveDataDic;

		public int currentCharacterIndexInParty;

		public static DmodeModel Instance => null;

		public QuestEventGroupElement QuestEventGroupElement => null;

		public DmodeSettingElement DmodeSetting => null;

		public static void DeleteInstance()
		{
		}

		public static bool IsInstanceNull()
		{
			return default(bool);
		}

		static DmodeModel()
		{
		}

		public void LoadData()
		{
		}

		public void UpdateDmodeInfoData()
		{
		}

		public static int GetRecoveryCount(int lastRecoveryTime)
		{
			return default(int);
		}

		private int GetDailyFloorSkipCount(int lastSkipCountUpdateTime)
		{
			return default(int);
		}

		public static void GetExpeditionMaxFloor(out int maxFloor, out int totalSecond)
		{
		}

		public void UpdateDmodeCharaListData()
		{
		}

		public void UpdateDmodeDungeonInfoData()
		{
		}

		public void UpdateDmodeServitorPassiveList()
		{
		}

		public void StartRequestDungeonStart(int leaderCharaId, int startFloorNum, Action onSuccess)
		{
		}

		public static void CheckDmodeForBeforeTransition(UnityAction completeCallback, [Optional] UnityAction cancelledCallback)
		{
		}

		public static bool IsEntry()
		{
			return default(bool);
		}

		public static Task<DmodeGetDataResponse> RequestDmodeGetData(Action<ErrorType, int> onError)
		{
			return null;
		}

		public static Task<DmodeEntryResponse> RequestDmodeEntry(Action<ErrorType, int> onError)
		{
			return null;
		}

		public static Task<DmodeBuildupServitorPassiveResponse> RequestDmodeBuildupServitorPassive(DmodeServitorPassiveList[] passives, Action<ErrorType, int> onError)
		{
			return null;
		}

		public static Task<TreasureTradeGetListAllResponse> RequestDmodelTreasureTradeGetListAllResponse(Action<ErrorType, int> onError)
		{
			return null;
		}

		public static Task<DmodeDungeonRestartResponse> RequestDmodeDungeonRestart(Action<ErrorType, int> onError)
		{
			return null;
		}

		public static Task<DmodeDungeonFinishResponse> RequestDmodeDungeonFinish(bool isGameOver, Action<ErrorType, int> onError)
		{
			return null;
		}

		public static Task<DmodeDungeonUserHaltResponse> RequestDmodeDungeonUserHalt(Action<ErrorType, int> onError)
		{
			return null;
		}

		public static Task<DmodeReadStoryResponse> RequestDmodeReadStory(int storyId, Action<ErrorType, int> onError)
		{
			return null;
		}

		public static void OnRequestError(ErrorType errorType, int errorCode)
		{
		}

		private static void GotoPrologue()
		{
		}

		private static void DownLoadDmodeData(UnityAction completeCallback, UnityAction cancelledCallback)
		{
		}

		public static DmodeServitorPassiveElement GetDmodeServitorPassive(DmodeServitorPassiveType type)
		{
			return null;
		}

		public static DmodeServitorPassiveLevelElement GetDmodeServitorPassiveLevelElementFromLevel(int passiveNo, int level)
		{
			return null;
		}

		public static int GetMaxPassiveLevel(int passiveNo)
		{
			return default(int);
		}

		public static DmodeServitorElement GetDmodeServitor(DmodeServitorType type)
		{
			return null;
		}

		public static SkillDataElement GetSkillDataFromDmodeServitorType(DmodeServitorType type)
		{
			return null;
		}

		public static Dictionary<int, int> GetNeedMaterial(int releaseCount, int passiveNo, int passiveLevelNow)
		{
			return null;
		}

		public static bool ExchangeItemExists()
		{
			return default(bool);
		}

		public static void StartRequestDungeonStart(int charaId, int editSkillCharaId1, int editSkillCharaId2, DmodeServitorType servitorType, int startFloorNum, Action onSuccess)
		{
		}

		public static void GoToIngame()
		{
		}

		public static void CalcDefaultEditSkillCharaId(int unitCharaId, out int defaultEditSkill1, out int defaultEditSkill2)
		{
		}

		public static bool IsExpeditionCharacter(int charaId)
		{
			return default(bool);
		}

		public static bool IsStoryNewReleasedExists()
		{
			return default(bool);
		}
	}
}
