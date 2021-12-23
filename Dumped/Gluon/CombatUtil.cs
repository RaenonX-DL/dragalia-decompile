using System;
using Gluon.Master;

namespace Gluon
{
	public static class CombatUtil
	{
		[Serializable]
		public class QuestPartySetting
		{
			public int charactorId;

			public ulong dragonId;

			public int weaponBodyId;

			public int weaponSkinId;

			public int editSkill1CharaId;

			public int editSkill2CharaId;

			public int crest11Id;

			public int crest12Id;

			public int crest13Id;

			public int crest21Id;

			public int crest22Id;

			public int crest31Id;

			public int crest32Id;

			public ulong talismanId;
		}

		public enum CombatEventTalkCategory0
		{
			Top = 1,
			ShowResult,
			Hint
		}

		public enum CombatEventHintCategory1
		{
			Normal = 1,
			End
		}

		private const string partyPrefKeyDragon = "CombatDragonOnly.party";

		private const string partyPrefKeyArena = "CombatArenaSolo.party";

		private const int dragonRelayUnitNum = 4;

		public static int GetEventItemValue(int eventItemId)
		{
			return default(int);
		}

		public static string GetHintMessage()
		{
			return null;
		}

		public static CombatEventTalkElement GetCombatEventTalkResultContent(int eventGroupId, EventQuestModel.BuildCharaTalkResultCategory1 category, EventQuestModel.BuildCharaTalkResultTargetType type)
		{
			return null;
		}

		public static int GetEventItemValueByType(CombatEventItemType type)
		{
			return default(int);
		}

		public static bool IsDragonOnlyQuest(int questId)
		{
			return default(bool);
		}

		public static bool IsSoloUnitQuest(int questId)
		{
			return default(bool);
		}

		public static bool IsDragonOnly1UnitQuest(int questId)
		{
			return default(bool);
		}

		public static bool IsNormalSoloQuest(int questId)
		{
			return default(bool);
		}

		public static void SetSoloQuestParty(string keyString)
		{
		}

		private static void CheckSameBaseIdCrest(QuestPartySetting questPartySetting)
		{
		}

		private static void SetCrestId(QuestPartySetting questPartySetting, int index, int value)
		{
		}

		public static void SetDragonOnly1UnitQuestParty()
		{
		}

		public static void SetArenaQuestParty()
		{
		}

		public static void SaveSoloQuestParty(string keyString)
		{
		}

		public static void SaveDragonOnly1UnitQuestParty()
		{
		}

		public static void SaveArenaQuestParty()
		{
		}

		public static bool IsEnabledDragonOnlyQuest(int questId, ref string message)
		{
			return default(bool);
		}

		public static CombatEventLocationElement GetCombatLocation(int eventId, int locationId)
		{
			return null;
		}

		public static CombatEventLocationElement GetCombatLocationFromStoryId(int eventId, int storyId)
		{
			return null;
		}

		public static bool IsCombatEventQuest(QuestDataElement questDataElement)
		{
			return default(bool);
		}
	}
}
