/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class CombatUtil
	{
		// Fields
		private const string partyPrefKeyDragon = "CombatDragonOnly.party";
		private const string partyPrefKeyArena = "CombatArenaSolo.party";
		private const int dragonRelayUnitNum = 4;
	
		// Nested types
		[Serializable]
		public class QuestPartySetting
		{
			// Fields
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
	
			// Constructors
			public QuestPartySetting();
		}
	
		public enum CombatEventTalkCategory0
		{
			Top = 1,
			ShowResult = 2,
			Hint = 3
		}
	
		public enum CombatEventHintCategory1
		{
			Normal = 1,
			End = 2
		}
	
		// Methods
		public static int GetEventItemValue(int eventItemId);
		public static string GetHintMessage();
		public static CombatEventTalkElement GetCombatEventTalkResultContent(int eventGroupId, EventQuestModel.BuildCharaTalkResultCategory1 category, EventQuestModel.BuildCharaTalkResultTargetType type);
		public static int GetEventItemValueByType(CombatEventItemType type);
		public static bool IsDragonOnlyQuest(int questId);
		public static bool IsSoloUnitQuest(int questId);
		public static bool IsDragonOnly1UnitQuest(int questId);
		public static bool IsNormalSoloQuest(int questId);
		public static void SetSoloQuestParty(string keyString);
		private static void CheckSameBaseIdCrest(QuestPartySetting questPartySetting);
		private static void SetCrestId(QuestPartySetting questPartySetting, int index, int value);
		public static void SetDragonOnly1UnitQuestParty();
		public static void SetArenaQuestParty();
		public static void SaveSoloQuestParty(string keyString);
		public static void SaveDragonOnly1UnitQuestParty();
		public static void SaveArenaQuestParty();
		public static bool IsEnabledDragonOnlyQuest(int questId, ref string message);
		public static CombatEventLocationElement GetCombatLocation(int eventId, int locationId);
		public static CombatEventLocationElement GetCombatLocationFromStoryId(int eventId, int storyId);
		public static bool IsCombatEventQuest(QuestDataElement questDataElement);
	}
}
