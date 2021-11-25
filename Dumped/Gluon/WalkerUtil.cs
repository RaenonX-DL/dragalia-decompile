using System;
using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class WalkerUtil
	{
		[Serializable]
		private class QuestPartySetting
		{
			public int[] charactorId;

			public ulong[] dragonId;

			public int[] weaponBodyId;

			public int[] weaponSkinId;
		}

		private const string questCharacterPrefKey = "Walker.questPartyPrefKey2021";

		private const int questEventGroupId = 23001;

		private const int WalkerCharaId = 19900004;

		public const int PresentItemReliability = 200;

		public static int extraInformationId;

		public const string MyPageWalkerVoicesGroup = "VO_CHR_210128_01_MYPAGE";

		private const int prologueInfoId = 2044;

		public static bool IsWalkerEventId(int eventId)
		{
			return default(bool);
		}

		public static bool IsNeedToAddQuestList()
		{
			return default(bool);
		}

		public static bool IsWalkerEventDay()
		{
			return default(bool);
		}

		public static bool IsWalkerEvent()
		{
			return default(bool);
		}

		public static string GetPreloadUrl(string defaultUrl)
		{
			return null;
		}

		public static bool IsWalkerQuest(int questId)
		{
			return default(bool);
		}

		public static bool IsPlayingWalkerQuest()
		{
			return default(bool);
		}

		public static void SetWalkerQuestParty()
		{
		}

		public static void SaveWalkerQuestParty()
		{
		}

		public static List<DragonGiftDataElement> GetWalkerEventItemList()
		{
			return null;
		}

		public static int GetSimpleEventItemCount(int num)
		{
			return default(int);
		}

		public static bool IsWalkerChara(CharacterBase chara)
		{
			return default(bool);
		}

		public static bool IsWalkerChara(int charaId)
		{
			return default(bool);
		}
	}
}
