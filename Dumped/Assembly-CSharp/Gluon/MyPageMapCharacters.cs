/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageMapCharacters
	{
		// Fields
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
	
		// Nested types
		public class CharacterData
		{
			// Fields
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
	
			// Constructors
			public CharacterData(int characterId);
	
			// Methods
			public void InitEventCharacter(MypageLimitedAreaNPCElement element, string itemName);
			private bool IsSmallNhaam(CharaDataElement master);
			public OutGameCharacterTalkManager.TalkEntity GetGreetingTalkAt(int index, bool isPrologue);
			public OutGameCharacterTalkManager.TalkEntity GetTweetTalkAt(int index, bool isPrologue);
			public OutGameCharacterTalkManager.TalkEntity GetBigTalkAt(int index, bool isPrologue);
			public int GetGreetingTalkCount(bool isPrologue);
			public int GetTweetTalkCount(bool isPrologue);
			public int GetBigTalkCount(bool isPrologue);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public MyPageMapCharacters __4__this;
			public bool isRunning;
			public Predicate<int> __9__0;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal bool _GetMoveMapCharacters_b__0(int characterId);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_1
		{
			// Fields
			public CharacterData chosen;
	
			// Constructors
			public __c__DisplayClass18_1();
	
			// Methods
			internal bool _GetMoveMapCharacters_b__1(int num);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<int> __9__24_0;
			public static Predicate<int> __9__24_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _GetSkitMapCharacters_b__24_0(int x);
			internal bool _GetSkitMapCharacters_b__24_1(int x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public int result;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal bool _GetAvailableCharacter_b__0(int num);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public int baseId;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal bool _ContainsCharacter_b__0(CharacterData p);
		}
	
		// Constructors
		public MyPageMapCharacters();
		static MyPageMapCharacters();
	
		// Methods
		public void Init(MyPageTransitionController.QuestType questType, int zeshiQuestId);
		private bool IsForbiddenChara(int charaId);
		public List<CharacterData> GetMoveMapCharacters(MyPageTransitionController.MoveMapType currentType, int groundIndex, bool isRunning);
		private static bool IsMoveMapAvaliableCharacter(MyPageMoveMapCharaPosSettings moveMapCharaPosSettings, int characterId, bool isRunning, int index);
		public List<CharacterData> GetMoveMapCharactersFromLastList(MyPageTransitionController.MoveMapType currentType);
		public static void ClearLastCharacters();
		public int GetMapUsedCharacterNum();
		public List<CharacterData> OverrideSkitMapCharacters(MyPageSkitMapCharaInfo charaInfo);
		public List<CharacterData> GetSkitMapCharacters(MyPageTransitionController.SkitMapType type, MyPageTransitionController.SkitMapSeasonType seasonType, MyPageTransitionController.DayTimeType dayTimeType, bool isLimitedAreaOnMaster, int numOfSkitCharacters, int areaId);
		private bool IsExistSitMotion();
		private bool IsIgnoreCharacter(int characterId);
		private void LoadEventSkitMapCharacters(MyPageTransitionController.SkitMapType type, MyPageTransitionController.SkitMapSeasonType seasonType, MyPageTransitionController.DayTimeType dayTimeType, int areaId);
		public List<CharacterData> GetSkitMapCharactersFromLastList(MyPageTransitionController.SkitMapType currentType);
		public List<CharacterData> GetListFromIdArray(int[] arg);
		private CharacterData GetAvailableCharacter(List<int> candidates);
		public CharacterData GetMainCharacter();
		private CharacterData GetSkitMainCharacter();
		private CharacterData GetCharacter(int id);
		public bool ContainsCharacter(int baseId);
		[CompilerGenerated]
		private bool _GetSkitMapCharacters_b__24_2(int x);
		[CompilerGenerated]
		private bool _GetSkitMapCharacters_b__24_3(int x);
		[CompilerGenerated]
		private bool _GetSkitMapCharacters_b__24_4(int x);
		[CompilerGenerated]
		private bool _GetSkitMapCharacters_b__24_5(int x);
		[CompilerGenerated]
		private bool _GetSkitMapCharacters_b__24_6(int x);
		[CompilerGenerated]
		private bool _GetSkitMapCharacters_b__24_7(int num);
		[CompilerGenerated]
		private bool _GetSkitMapCharacters_b__24_8(int num);
		[CompilerGenerated]
		private bool _GetSkitMapCharacters_b__24_9(int num);
		[CompilerGenerated]
		private bool _GetSkitMapCharacters_b__24_10(int num);
	}
}
