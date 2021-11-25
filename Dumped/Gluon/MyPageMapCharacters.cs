using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class MyPageMapCharacters
	{
		public class CharacterData
		{
			public int characterId;

			public int baseId;

			public string itemName;

			public int personMotionType;

			public string modelName;

			public string characterName;

			public WeaponType weaponType;

			public bool isEventCharacter;

			public string eventText;

			public string eventVoiceId;

			public string eventVoiceGroupId;

			public int eventPositionIndex;

			public bool isDragon;

			public bool isSmallNhaam;

			public string dragonAnimationName;

			public CharacterData(int characterId)
			{
			}

			public void InitEventCharacter(MypageLimitedAreaNPCElement element, string itemName)
			{
			}

			private bool IsSmallNhaam(CharaDataElement master)
			{
				return default(bool);
			}

			public OutGameCharacterTalkManager.TalkEntity GetGreetingTalkAt(int index, bool isPrologue)
			{
				return null;
			}

			public OutGameCharacterTalkManager.TalkEntity GetTweetTalkAt(int index, bool isPrologue)
			{
				return null;
			}

			public OutGameCharacterTalkManager.TalkEntity GetBigTalkAt(int index, bool isPrologue)
			{
				return null;
			}

			public int GetGreetingTalkCount(bool isPrologue)
			{
				return default(int);
			}

			public int GetTweetTalkCount(bool isPrologue)
			{
				return default(int);
			}

			public int GetBigTalkCount(bool isPrologue)
			{
				return default(int);
			}
		}

		public MyPageScene scene;

		public int mainCharacterId;

		public int skitMainCharaId;

		public bool isZeshiaIncluded;

		private Dictionary<int, CharacterData> charaDataDict;

		private static int lastCharacterCount;

		private static List<int> lastMoveMapCharacterIds;

		private static List<int> lastSkitMapCharacterIds;

		private static MyPageTransitionController.SkitMapType lastSkitMapType;

		private static MyPageTransitionController.DayTimeType lastSkitMapDayTimeType;

		private static int lastMoveMapGroundIndex;

		private static int lastMainCharacterId;

		private bool isInitialCharaSelect;

		private List<int> allCharacterIdList;

		private List<CharacterData> mapUsedCharacterList;

		public void Init(MyPageTransitionController.QuestType questType, int zeshiQuestId)
		{
		}

		private bool IsForbiddenChara(int charaId)
		{
			return default(bool);
		}

		public List<CharacterData> GetMoveMapCharacters(MyPageTransitionController.MoveMapType currentType, int groundIndex, bool isRunning)
		{
			return null;
		}

		private static bool IsMoveMapAvaliableCharacter(MyPageMoveMapCharaPosSettings moveMapCharaPosSettings, int characterId, bool isRunning, int index)
		{
			return default(bool);
		}

		public List<CharacterData> GetMoveMapCharactersFromLastList(MyPageTransitionController.MoveMapType currentType)
		{
			return null;
		}

		public static void ClearLastCharacters()
		{
		}

		public int GetMapUsedCharacterNum()
		{
			return default(int);
		}

		public List<CharacterData> OverrideSkitMapCharacters(MyPageSkitMapCharaInfo charaInfo)
		{
			return null;
		}

		public List<CharacterData> GetSkitMapCharacters(MyPageTransitionController.SkitMapType type, MyPageTransitionController.SkitMapSeasonType seasonType, MyPageTransitionController.DayTimeType dayTimeType, bool isLimitedAreaOnMaster, int numOfSkitCharacters, int areaId)
		{
			return null;
		}

		private bool IsExistSitMotion()
		{
			return default(bool);
		}

		private bool IsIgnoreCharacter(int characterId)
		{
			return default(bool);
		}

		private void LoadEventSkitMapCharacters(MyPageTransitionController.SkitMapType type, MyPageTransitionController.SkitMapSeasonType seasonType, MyPageTransitionController.DayTimeType dayTimeType, int areaId)
		{
		}

		public List<CharacterData> GetSkitMapCharactersFromLastList(MyPageTransitionController.SkitMapType currentType)
		{
			return null;
		}

		public List<CharacterData> GetListFromIdArray(int[] arg)
		{
			return null;
		}

		private CharacterData GetAvailableCharacter(List<int> candidates)
		{
			return null;
		}

		public CharacterData GetMainCharacter()
		{
			return null;
		}

		private CharacterData GetSkitMainCharacter()
		{
			return null;
		}

		private CharacterData GetCharacter(int id)
		{
			return null;
		}

		public bool ContainsCharacter(int baseId)
		{
			return default(bool);
		}
	}
}
