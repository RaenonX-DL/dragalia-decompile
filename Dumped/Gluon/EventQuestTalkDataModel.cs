using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class EventQuestTalkDataModel
	{
		public class TalkSet
		{
			public int id;

			public string charaImage;

			public int imageIndex;

			public string voiceData;

			public string charaName;

			public string text;

			public Vector2 posOffset;

			public Vector2 moveOffset;

			public TalkSet(int id, string charaImage, int imageIndex, string text, string voiceData, string charaName, Vector2 posOffset, Vector2 moveOffset)
			{
			}
		}

		public enum RaidCharaTalkCategory0
		{
			Top = 1,
			Result,
			HintMessage,
			QuestDescription,
			ExBattleShowUp
		}

		public enum RaidCharaTalkCategory1
		{
			Friendship = 1,
			Reward,
			End,
			BeforeJoin,
			StoryProgress
		}

		public enum RaidResultCharaTalkHintMessageCategory1
		{
			FriendShip = 1,
			End,
			BeforeJoin
		}

		private enum Clb01TopState0
		{
			StoryClear = 1,
			QuestClear,
			EventEnd,
			UnlockStoryCondition,
			UnlockStoryPU
		}

		public enum Clb01TalkCategory0
		{
			Top = 1,
			Result,
			Hint
		}

		public enum Clb01TalkTopCategory1
		{
			StoryClear = 1,
			EventEnd,
			Redeemable
		}

		public enum Clb01TalkResultCategory1
		{
			BeforeJoin = 1,
			Friendship,
			Max
		}

		public enum Clb01UnlockStoryPUCategory1
		{
			Normal = 1,
			Insufficient
		}

		public enum ExHunterTalkCategory0
		{
			Top = 1,
			Result,
			Hint
		}

		public enum ExHunterTalkTopCategory1
		{
			StoryClear = 1,
			Redeemable,
			EventEnd
		}

		public enum CombatEventTalkCategory0
		{
			Top = 1,
			Result,
			Hint
		}

		public enum CombatEventTalkTopCategory1
		{
			Quest = 1,
			ExQuest,
			Story,
			TradeItem,
			Normal,
			Touch,
			EventEnd
		}

		public enum BattleRoyalTalkTopCategory
		{
			Top = 1,
			Result,
			Hint
		}

		public enum EarnEventTalkCategory0
		{
			Top = 1,
			Result,
			Hint,
			QuestDescription
		}

		public enum EarnEventTalkEventTopCategory1
		{
			QuestClear = 1,
			Touch,
			EventEnd
		}

		public enum EarnEventTalkQuestResultCategory1
		{
			ScoreResultStart = 1,
			ScoreResultPresentation,
			ScoreResultRewardGet
		}

		public enum EarnEventTalkHintCategory1
		{
			StoryRead = 1,
			EventEnd
		}

		public enum EarnEventTalkQuestDecscriptionCategory1
		{
			RewardQuest = 1
		}

		private static EventQuestTalkDataModel instance;

		public Dictionary<string, List<TalkSet>> availableTalkCharaSetDic;

		private int currentPlayingId;

		public List<string> preferredCharaList;

		public List<int> enableMiniCharaList;

		public List<string> enableCommonCharaList;

		private int eventId;

		private EventKindType eventType;

		public bool onCharaTouchMode;

		public static EventQuestTalkDataModel Instance => null;

		public static void DeleteInstance()
		{
		}

		public static bool IsInstanceNull()
		{
			return default(bool);
		}

		private List<int> Clb01AddTopMiniChara(Clb01EventTopElement elem)
		{
			return null;
		}

		public TalkSet SwitchToMiniCharaAndTalk(int index)
		{
			return null;
		}

		public void Setup(int eventId, EventKindType eventType)
		{
		}

		public void Clear()
		{
		}

		public TalkSet GetFriendshipResultTalk(int friendship, bool forceMax)
		{
			return null;
		}

		public TalkSet GetBuildResultTalk(EventQuestModel.BuildCharaTalkResultCategory1 category, EventQuestModel.BuildCharaTalkResultTargetType targetType)
		{
			return null;
		}

		public TalkSet GetCombatTalk(EventQuestModel.BuildCharaTalkResultCategory1 category, EventQuestModel.BuildCharaTalkResultTargetType targetType)
		{
			return null;
		}

		public TalkSet GetEarnTalk(EventQuestModel.BuildCharaTalkResultCategory1 category, EventQuestModel.BuildCharaTalkResultTargetType targetType)
		{
			return null;
		}

		private TalkSet WrapClb01Talk(Clb01EventTalkElement item)
		{
			return null;
		}

		private TalkSet WrapBattleRoyalTalk(BattleRoyalEventTalkElement item)
		{
			return null;
		}

		private TalkSet WrapExHunterTalk(ExHunterEventTalkElement item)
		{
			return null;
		}

		private TalkSet WrapExRushTalk(ExRushEventTalkElement item)
		{
			return null;
		}

		private TalkSet WrapRaidTalk(RaidEventTalkElement item)
		{
			return null;
		}

		private TalkSet WrapBuildTalk(BuildEventTalkElement item)
		{
			return null;
		}

		private TalkSet WrapCombatTalk(CombatEventTalkElement item)
		{
			return null;
		}

		private TalkSet WrapEarnTalk(EarnEventTalkElement item)
		{
			return null;
		}

		public TalkSet GetAvailableTalk()
		{
			return null;
		}

		public TalkSet GetCurrentPlayingTalk()
		{
			return null;
		}

		public (string, string, string) GetStoryUnlockConditionText(int payEventItemId)
		{
			return default((string, string, string));
		}

		private string ConvertTopCharaImage(string imageName)
		{
			return null;
		}

		private Dictionary<string, string> GetBuildChangeCharaDictionary(BuildEventTalk talkData)
		{
			return null;
		}

		private string GetTopCharaImageWithCharaChangeDic(BuildEventTalkElement item, Dictionary<string, string> changeCharaDic)
		{
			return null;
		}

		public void GatherAvailableTalks()
		{
		}

		public static Clb01EventTopElement GetClb01EventTopElement(int eventId)
		{
			return null;
		}

		public static string GetEarnHintMessage(int curEventId)
		{
			return null;
		}

		public static string GetEarnQuestDescription(int curEventId, EarnEventTalkQuestDecscriptionCategory1 category1)
		{
			return null;
		}
	}
}
