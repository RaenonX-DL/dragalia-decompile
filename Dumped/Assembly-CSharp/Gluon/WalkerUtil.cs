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
	public class WalkerUtil
	{
		// Fields
		private const string questCharacterPrefKey = "Walker.questPartyPrefKey2021";
		private const int questEventGroupId = 23001;
		private const int WalkerCharaId = 19900004;
		public const int PresentItemReliability = 200;
		public static int extraInformationId;
		public const string MyPageWalkerVoicesGroup = "VO_CHR_210128_01_MYPAGE";
		private const int prologueInfoId = 2044;
	
		// Nested types
		[Serializable]
		private class QuestPartySetting
		{
			// Fields
			public int[] charactorId;
			public ulong[] dragonId;
			public int[] weaponBodyId;
			public int[] weaponSkinId;
	
			// Constructors
			public QuestPartySetting();
		}
	
		// Constructors
		public WalkerUtil();
		static WalkerUtil();
	
		// Methods
		public static bool IsWalkerEventId(int eventId);
		public static bool IsNeedToAddQuestList();
		public static bool IsWalkerEventDay();
		public static bool IsWalkerEvent();
		public static string GetPreloadUrl(string defaultUrl);
		public static bool IsWalkerQuest(int questId);
		public static bool IsPlayingWalkerQuest();
		public static void SetWalkerQuestParty();
		public static void SaveWalkerQuestParty();
		public static List<DragonGiftDataElement> GetWalkerEventItemList();
		public static int GetSimpleEventItemCount(int num);
		public static bool IsWalkerChara(CharacterBase chara);
		public static bool IsWalkerChara(int charaId);
	}
}
