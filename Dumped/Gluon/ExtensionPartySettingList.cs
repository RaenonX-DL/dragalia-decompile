using Gluon.Http;

namespace Gluon
{
	public static class ExtensionPartySettingList
	{
		public static int GetWeapon(this PartySettingList item)
		{
			return default(int);
		}

		public static int GetCrest(this PartySettingList self, int typeNo, int num)
		{
			return default(int);
		}

		public static void SetData(this PartySettingList self, int unitNo, QuestPrepareData partyData)
		{
		}

		public static void SetData(this PartySettingList self, PartySettingList dest)
		{
		}

		public static void SetData(this PartySettingList self, PartyUnitList unitList)
		{
		}

		public static int GetAbilityCrestId(PartyUnitList unitList, int typeNo, int index)
		{
			return default(int);
		}
	}
}
